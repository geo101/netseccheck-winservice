namespace SecEventChecker
{
    partial class SecEventChecker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public bool lProcessing = false;

        /// <summary>
        /// Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            // 
            // timer1
            // 
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // SecEventChecker
            // 
            this.ServiceName = "Scanner Lock Checker";
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();

        }

        private System.Timers.Timer timer1;
    }
}
