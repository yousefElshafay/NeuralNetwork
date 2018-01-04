namespace NeuroNetWorkExperiment
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
            this.Canvas = new System.Windows.Forms.Panel();
            this.BtnDrawNetWork = new System.Windows.Forms.Button();
            this.BtnCreateNetwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(702, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(500, 440);
            this.Canvas.TabIndex = 0;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.DoubleClick += new System.EventHandler(this.Canvas_DoubleClick);
            this.Canvas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDoubleClick);
            // 
            // BtnDrawNetWork
            // 
            this.BtnDrawNetWork.Location = new System.Drawing.Point(437, 136);
            this.BtnDrawNetWork.Name = "BtnDrawNetWork";
            this.BtnDrawNetWork.Size = new System.Drawing.Size(204, 82);
            this.BtnDrawNetWork.TabIndex = 0;
            this.BtnDrawNetWork.Text = "DrawNetwork";
            this.BtnDrawNetWork.UseVisualStyleBackColor = true;
            this.BtnDrawNetWork.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCreateNetwork
            // 
            this.BtnCreateNetwork.Location = new System.Drawing.Point(67, 136);
            this.BtnCreateNetwork.Name = "BtnCreateNetwork";
            this.BtnCreateNetwork.Size = new System.Drawing.Size(232, 82);
            this.BtnCreateNetwork.TabIndex = 1;
            this.BtnCreateNetwork.Text = "CreateNetWork";
            this.BtnCreateNetwork.UseVisualStyleBackColor = true;
            this.BtnCreateNetwork.Click += new System.EventHandler(this.BtnCreateNetwork_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 539);
            this.Controls.Add(this.BtnCreateNetwork);
            this.Controls.Add(this.BtnDrawNetWork);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button BtnDrawNetWork;
        private System.Windows.Forms.Button BtnCreateNetwork;
    }
}

