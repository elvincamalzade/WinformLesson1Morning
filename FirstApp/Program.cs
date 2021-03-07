using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    static class Program
    {
        #region MessageBoxes

        //static DialogResult GetDialogResult()
        //{
        //    DialogResult result;
        //    string message = "Window displays text message";
        //    //result=MessageBox.Show(message);
        //    string caption = "C# programming";
        //    //result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);

        //    result = MessageBox.Show(message, caption, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

        //    return result;
        //}

        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    //Application.EnableVisualStyles();
        //    //Application.SetCompatibleTextRenderingDefault(false);
        //    //Application.Run(new Form1());


        //    var dialog = GetDialogResult();

        //    //if (dialog == DialogResult.OK)
        //    //{
        //    //    MessageBox.Show("You clicked to OKAY");
        //    //}
        //    //else if (dialog == DialogResult.Cancel)
        //    //{
        //    //    MessageBox.Show("You clicked to Cancel");
        //    //}


        //    if (dialog == DialogResult.Abort)
        //    {
        //        MessageBox.Show("You clicked to ABORT");
        //    }
        //    else if (dialog == DialogResult.Retry)
        //    {
        //        MessageBox.Show("You clicked to RETRY");
        //    }
        //    else if (dialog == DialogResult.Ignore)
        //    {
        //        MessageBox.Show("You clicked to IGNORE");
        //    }
        //}
        #endregion



        #region Work With Forms

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #endregion
    }
}
