using System;
using System.IO;
using System.Windows.Forms;

namespace CanvasAPIApp
{
    class Template
    {

        private FileStream input;
        private StreamReader fileReader;
        private StreamWriter fileWriter;
        private Form currentForm;

        public Template(Form thisForm)
        {
            currentForm = thisForm;
        }

        public void SaveTemplate()
        {

            //create and show dialog box enabling user to save file
            DialogResult result; //result of SaveFileDialog
            string fileName;
            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; //makes fileName equal the file the user choose
            }

            //ensure user clicked OK
            if (result == DialogResult.OK)
            {
                // show error if user specified invalid file
                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //save file with filestream if user chose good file
                    try
                    {
                        //open file with write access
                        FileStream output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                        //sets file to where data is written
                        fileWriter = new StreamWriter(output);
                        string writeToFile = "";
                        try
                        {
                            foreach (Control c in currentForm.Controls)
                            {
                                string controlType = c.GetType().ToString();
                                //write record to file
                                switch (controlType)
                                {
                                    case "System.Windows.Forms.TextBox":
                                        writeToFile += ("txt" + c.Text + ",");
                                        break;
                                    case "System.Windows.Forms.CheckBox":
                                        writeToFile += ("chb" + (c as CheckBox).Checked + ",");
                                        break;
                                    case "System.Windows.Forms.NumericUpDown":
                                        if (c.Name != "nudCourseID")
                                            writeToFile += ("nud" + (c as NumericUpDown).Value + ",");
                                        else
                                            writeToFile += "nul,";
                                        break;
                                    case "System.Windows.Forms.ComboBox":
                                        writeToFile += ("cbx" + (c as ComboBox).SelectedText + ",");
                                        break;
                                    case "System.Windows.Forms.DateTimePicker":
                                        writeToFile += ("dtp" + (c as DateTimePicker).Value + ",");
                                        break;
                                    case "System.Windows.Forms.RichTextBox":
                                        if (c.Name == "rtbQuizInstructions")
                                            writeToFile += ("rtb" + (c as RichTextBox).Text + ",");
                                        else
                                            writeToFile += ("nul,");
                                        break;
                                    default:
                                        writeToFile += ("nul,");
                                        break;
                                }
                            }

                            fileWriter.Write(writeToFile);
                            fileWriter.Close();
                            output.Close();

                            MessageBox.Show("Successfully Saved");
                            try
                            {
                                fileWriter.Close();
                            }
                            catch (IOException)
                            {
                                MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        //output operation error
                        catch (IOException)
                        {
                            MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //parameter format error
                        catch (FormatException)
                        {
                            MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //handle exceptions
                    catch (IOException)
                    {
                        //notify user if file does not exist
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        public void LoadTemplate()
        {
            string fileName;
            try
            {
                //create dialog box for open file
                DialogResult result;

                using (OpenFileDialog fileChooser = new OpenFileDialog())
                {
                    result = fileChooser.ShowDialog();
                    fileName = fileChooser.FileName;
                }

                //exit event handler if cancel is clicked
                if (result == DialogResult.OK)
                {
                    //error for invalid file
                    if (fileName == string.Empty)
                        MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        //filestream to obtain read access to file
                        input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        //set file from where data is read
                        fileReader = new StreamReader(input);
                        MessageBox.Show(currentForm.ToString());
                    }
                    while (true)
                    {
                        string[] inputFields; //store individual pieces of data

                        //get next record
                        string inputRecord = fileReader.ReadLine();

                        //when at the end of file exit method
                        if (inputRecord == null)
                            return;

                        inputFields = inputRecord.Split(','); //parse input

                        int fieldCount = 0;

                        MessageBox.Show(inputRecord.ToString());

                        foreach (Control c in currentForm.Controls)
                        {
                            if (fieldCount < currentForm.Controls.Count)
                            {
                                string field = inputFields[fieldCount];
                                string dataType = "";
                                if (field.Length > 1)
                                {
                                    dataType = field.Substring(0, 3);
                                }

                                switch (dataType)
                                {
                                    case "txt":
                                        (currentForm.Controls[c.Name] as TextBox).Text = (field.Substring(3, field.Length - 3));
                                        break;
                                    case "rtb":
                                        (currentForm.Controls[c.Name] as RichTextBox).Text = (field.Substring(3, field.Length - 3));
                                        break;
                                    case "chb":
                                        MessageBox.Show(field);
                                        (currentForm.Controls[c.Name] as CheckBox).Checked = Convert.ToBoolean((field.Substring(3, field.Length - 3)));
                                        break;
                                    case "nud":
                                        if (c.Name != "nudCourseID")
                                            (currentForm.Controls[c.Name] as NumericUpDown).Value = Convert.ToInt32((field.Substring(3, field.Length - 3)));
                                        break;
                                    case "ComboBox":
                                        (currentForm.Controls[c.Name] as ComboBox).SelectedText = ((field.Substring(3, field.Length - 3)));
                                        break;
                                    case "DateTimePicker":
                                        (currentForm.Controls[c.Name] as DateTimePicker).Value = Convert.ToDateTime((field.Substring(3, field.Length - 3)));
                                        break;
                                    case "nul":
                                        break;
                                }
                            }
                            else
                            {
                                currentForm.Refresh();
                                return;
                            }

                            fieldCount++;
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot Read File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
