namespace IES_2
{
    partial class frmOneByte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOneByte));
            this.btnApply = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblAdjTitle = new System.Windows.Forms.Label();
            this.tbAdjVal = new System.Windows.Forms.TextBox();
            this.tbAdjTrack = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdjTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnFinish
            // 
            resources.ApplyResources(this.btnFinish, "btnFinish");
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblAdjTitle
            // 
            resources.ApplyResources(this.lblAdjTitle, "lblAdjTitle");
            this.lblAdjTitle.Name = "lblAdjTitle";
            // 
            // tbAdjVal
            // 
            resources.ApplyResources(this.tbAdjVal, "tbAdjVal");
            this.tbAdjVal.Name = "tbAdjVal";
            this.tbAdjVal.TextChanged += new System.EventHandler(this.tbAdjVal_TextChanged);
            this.tbAdjVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdjVal_KeyPress);
            // 
            // tbAdjTrack
            // 
            resources.ApplyResources(this.tbAdjTrack, "tbAdjTrack");
            this.tbAdjTrack.Maximum = 255;
            this.tbAdjTrack.Name = "tbAdjTrack";
            this.tbAdjTrack.TickFrequency = 5;
            this.tbAdjTrack.ValueChanged += new System.EventHandler(this.tbAdjTrack_ValueChanged);
            // 
            // frmOneByte
            // 
            this.AcceptButton = this.btnApply;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.tbAdjTrack);
            this.Controls.Add(this.tbAdjVal);
            this.Controls.Add(this.lblAdjTitle);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOneByte";
            ((System.ComponentModel.ISupportInitialize)(this.tbAdjTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnFinish;
        public System.Windows.Forms.Label lblAdjTitle;
        private System.Windows.Forms.TextBox tbAdjVal;
        public System.Windows.Forms.TrackBar tbAdjTrack;
    }
}