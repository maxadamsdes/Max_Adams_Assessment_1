﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaCSharpApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form : System.Windows.Forms.Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8.0F, 16.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form";
            Text = "Cinemas";
            Load += new EventHandler(Cinemas_Load);
            ResumeLayout(false);
        }
    }
}