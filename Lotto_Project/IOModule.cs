﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*! \namespace IOModule
 * \brief This NameSpace provides classes and functions to input and output data.
 */
namespace IOModule
{
    /*! \class OutputModule
     * \brief Provides functions to  write program output to a file of the users choice. 
     * 
     * Provides functions to get file names; preferred separators and output content to a file. 
     */
    class OutputModule
    {
        static private OutputModule IOM = null; 
        //! \brief Constructor for singleton pattern.
        private OutputModule()
        {
            
        }
        //! \brief Destructor 
        ~OutputModule()
        {
            
        }
        //! \brief Returns an instant of the OutPutWriter or creats it if it doesn’t exist. (part of the singleton patten).
        static public OutputModule getInstance()
        {
            if (IOM ==null)
                IOM = new OutputModule();
            return IOM;
        }
        //! \brief Gets the file name from the user with the file types in the extentions variable. 
        static public string getFileName(out string separator, string extention = "CSV | *.csv | TSV | *.tsv | Text | *.txt | Word | *.doc | All Files | *.*")
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string fileName = null;
            int indexValue = 0;
            sfd.InitialDirectory = ".../...";
            sfd.DefaultExt = "*.*";
            sfd.Filter = extention;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                indexValue = sfd.FilterIndex;
            }
            if (indexValue == 1)
                separator = ",";
            else if(indexValue == 2)
                separator = "\t";
            else
                separator = " ";
            return fileName;
        }
        //! \brief writes formated text to file.
        public void TextToFile(string text, string fileName = null)
        {
            string temp;
            if (fileName == null)
                fileName = getFileName(out temp, "Text file (*txt) | *.txt | All files (*.*) | *.* | Word (*.doc) | *.doc");
            if (fileName != null)
                System.IO.File.WriteAllText(fileName, text);
        }
        //! \brief Writes dat in a CSV format to a user selected file.
        public void ToSeparatedFile(Dictionary<int, int> data, List<string> headers, string FileName, string separator = ",")
        {
            string text = null;
            foreach (string item in headers)
                text += item + separator;
            text += "\n";
            foreach (KeyValuePair<int, int> pair in data)
                text += pair.Key + separator + pair.Value + "\n";
            TextToFile(text, FileName);
        }
        //! \brief Writes dat in a CSV format to a user selected file.
        public void ToSeparatedFile(List<List<int>> data, List<string> headers, string FileName, string separator = ",")
        {
            string text = null;
            foreach (string item in headers)
                text += item + separator;
            text += "\n";
            foreach (List<int> list in data)
            {
                foreach (int item in list)
                    text += item.ToString() + separator;
                text += "\n";
            }
            TextToFile(text, FileName);
        }
    }
}