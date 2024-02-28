using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DVLD.Global_Classes
{
    public class clsGlobal
    {
        // Specify the Registry key and path
        private static string  _keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
        private static string _valueName = "LoginUser";

        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            
            string valueData = $"{Username}#//#{Password}";

            try
            {
                // Write the value to the Registry
                Registry.SetValue(_keyPath, _valueName, valueData, RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

            //try
            //{
            //    //this will get the current project directory folder.
            //    string currentDirectory = System.IO.Directory.GetCurrentDirectory();


            //    // Define the path to the text file where you want to save the data
            //    string filePath = currentDirectory + "\\data.txt";

            //    //incase the username is empty, delete the file
            //    if (Username == "" && File.Exists(filePath))
            //    {
            //        File.Delete(filePath);
            //        return true;

            //    }

            //    // concatonate username and passwrod withe seperator.
            //    string dataToSave = Username + "#//#" + Password;

            //    // Create a StreamWriter to write to the file
            //    using (StreamWriter writer = new StreamWriter(filePath))
            //    {
            //        // Write the data to the file
            //        writer.WriteLine(dataToSave);

            //        return true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //    return false;
            //}

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {

              

                try
                {
                    // Read the value from the Registry
                    string value = Registry.GetValue(_keyPath,_valueName, null) as string;

                    if (value != null)
                    {
                        string[] result = value.Split(new string[] { "#//#" }, StringSplitOptions.None);

                        Username = result[0];
                        Password = result[1];
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show($"Value {valueName} not found in the Registry.");
                        return false;
                    }
                }
                catch (Exception ex)
                {

                    return false;
                }

 





            ////this will get the stored username and password and will return true if found and false if not found.
            //try
            //{
            //    //gets the current project's directory
            //    string currentDirectory = System.IO.Directory.GetCurrentDirectory();

            //    // Path for the file that contains the credential.
            //    string filePath = currentDirectory + "\\data.txt";

            //    // Check if the file exists before attempting to read it
            //    if (File.Exists(filePath))
            //    {
            //        // Create a StreamReader to read from the file
            //        using (StreamReader reader = new StreamReader(filePath))
            //        {
            //            // Read data line by line until the end of the file
            //            string line;
            //            while ((line = reader.ReadLine()) != null)
            //            {
            //                Console.WriteLine(line); // Output each line of data to the console
            //                string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

            //                Username = result[0];
            //                Password = result[1];
            //            }
            //            return true;
            //        }
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //    return false;
            //}

        }


    }
}
