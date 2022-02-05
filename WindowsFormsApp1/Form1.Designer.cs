
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVMStatus = new System.Windows.Forms.Button();
            this.btnStartVM = new System.Windows.Forms.Button();
            this.btnGetIpAddress = new System.Windows.Forms.Button();
            this.btnStopMachine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVMStatus
            // 
            this.btnVMStatus.Location = new System.Drawing.Point(153, 44);
            this.btnVMStatus.Name = "btnVMStatus";
            this.btnVMStatus.Size = new System.Drawing.Size(187, 23);
            this.btnVMStatus.TabIndex = 0;
            this.btnVMStatus.Text = "Check VM Status";
            this.btnVMStatus.UseVisualStyleBackColor = true;
            this.btnVMStatus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartVM
            // 
            this.btnStartVM.Location = new System.Drawing.Point(153, 91);
            this.btnStartVM.Name = "btnStartVM";
            this.btnStartVM.Size = new System.Drawing.Size(187, 23);
            this.btnStartVM.TabIndex = 1;
            this.btnStartVM.Text = "Start VM";
            this.btnStartVM.UseVisualStyleBackColor = true;
            this.btnStartVM.Click += new System.EventHandler(this.btnStartVM_Click);
            // 
            // btnGetIpAddress
            // 
            this.btnGetIpAddress.Location = new System.Drawing.Point(153, 139);
            this.btnGetIpAddress.Name = "btnGetIpAddress";
            this.btnGetIpAddress.Size = new System.Drawing.Size(187, 23);
            this.btnGetIpAddress.TabIndex = 2;
            this.btnGetIpAddress.Text = "Get IP Address";
            this.btnGetIpAddress.UseVisualStyleBackColor = true;
            this.btnGetIpAddress.Click += new System.EventHandler(this.btnGetIpAddress_Click);
            // 
            // btnStopMachine
            // 
            this.btnStopMachine.Location = new System.Drawing.Point(153, 187);
            this.btnStopMachine.Name = "btnStopMachine";
            this.btnStopMachine.Size = new System.Drawing.Size(187, 23);
            this.btnStopMachine.TabIndex = 3;
            this.btnStopMachine.Text = "Stop Machine";
            this.btnStopMachine.UseVisualStyleBackColor = true;
            this.btnStopMachine.Click += new System.EventHandler(this.btnStopMachine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 335);
            this.Controls.Add(this.btnStopMachine);
            this.Controls.Add(this.btnGetIpAddress);
            this.Controls.Add(this.btnStartVM);
            this.Controls.Add(this.btnVMStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVMStatus;
        private System.Windows.Forms.Button btnStartVM;
        private System.Windows.Forms.Button btnGetIpAddress;
        private System.Windows.Forms.Button btnStopMachine;
    }
}

