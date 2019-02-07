
using System;
using Aveva.ApplicationFramework.Presentation;
using Aveva.PDMS.PMLNet;

namespace Polymetal.Pdms.Design.DrawListManager
{
    [PMLNetCallable()]
    public class DrawListManagerApp
    {

        [PMLNetCallable()]
        public DrawListManagerApp()
        {
        }

        [PMLNetCallable()]
        public void Assign(DrawListManagerApp that)
        {
        }

        [PMLNetCallable()]
        public void Show()
        {
            //var formnewform = new FormNew();
            //formnewform.Show(WindowManager.Instance.MainForm);

            try
            {
                var wpfForm = new DrawListManagerWpf();
                wpfForm.Show();
            }
            catch (Exception exception)
            {
                
                throw;
            }
           

         
        }
    }
}