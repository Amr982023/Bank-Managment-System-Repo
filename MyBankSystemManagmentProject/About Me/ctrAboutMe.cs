using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBankSystemManagmentProject
{
    public partial class ctrAboutMe : UserControl
    {
        public ctrAboutMe()
        {
            InitializeComponent();
        }

        private void Pb_FaceBook_Click(object sender, EventArgs e)
        {
            string facebookUrl = "https://www.facebook.com/amr.elbihedy"; 
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = facebookUrl,
                UseShellExecute = true
            });
        }

        private void pb_LinkedIn_Click(object sender, EventArgs e)
        {
            string LinkedInUrl = "https://www.linkedin.com/in/amr-elbehedy-0568a31b3/";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = LinkedInUrl,
                UseShellExecute = true
            });
        }

        private void pb_GitHub_Click(object sender, EventArgs e)
        {
       
            string GitHubUrl = "https://github.com/Amr982023";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = GitHubUrl,
                UseShellExecute = true
            });

        }

        private void pb_Gmail_Click(object sender, EventArgs e)
        {
            string email = "amr982011@gmail.com";
            string gmailUrl = $"https://mail.google.com/mail/?view=cm&fs=1&to={email}";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = gmailUrl,
                UseShellExecute = true
            });
        }

        private void Pb_Whatsapp_Click(object sender, EventArgs e)
        {
            string phoneNumber = "201068343401"; 
            string whatsappUrl = $"https://wa.me/{phoneNumber}";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = whatsappUrl,
                UseShellExecute = true
            });
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
            {
                clsGlobal.History.Pop();
            }
            this.Dispose();
        }

    }
}
