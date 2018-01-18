namespace CharacterSheet
{
    partial class MainForm
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
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.btnUpdateCharacter = new System.Windows.Forms.Button();
            this.btnDeleteCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Location = new System.Drawing.Point(20, 312);
            this.btnAddCharacter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(178, 51);
            this.btnAddCharacter.TabIndex = 0;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // lstCharacters
            // 
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.ItemHeight = 20;
            this.lstCharacters.Location = new System.Drawing.Point(18, 18);
            this.lstCharacters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(178, 224);
            this.lstCharacters.TabIndex = 1;
            // 
            // btnUpdateCharacter
            // 
            this.btnUpdateCharacter.Location = new System.Drawing.Point(238, 18);
            this.btnUpdateCharacter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateCharacter.Name = "btnUpdateCharacter";
            this.btnUpdateCharacter.Size = new System.Drawing.Size(146, 71);
            this.btnUpdateCharacter.TabIndex = 2;
            this.btnUpdateCharacter.Text = "Update Character";
            this.btnUpdateCharacter.UseVisualStyleBackColor = true;
            this.btnUpdateCharacter.Click += new System.EventHandler(this.btnUpdateCharacter_Click);
            // 
            // btnDeleteCharacter
            // 
            this.btnDeleteCharacter.Location = new System.Drawing.Point(238, 120);
            this.btnDeleteCharacter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCharacter.Name = "btnDeleteCharacter";
            this.btnDeleteCharacter.Size = new System.Drawing.Size(146, 72);
            this.btnDeleteCharacter.TabIndex = 3;
            this.btnDeleteCharacter.Text = "Delete Character";
            this.btnDeleteCharacter.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnDeleteCharacter);
            this.Controls.Add(this.btnUpdateCharacter);
            this.Controls.Add(this.lstCharacters);
            this.Controls.Add(this.btnAddCharacter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.ListBox lstCharacters;
        private System.Windows.Forms.Button btnUpdateCharacter;
        private System.Windows.Forms.Button btnDeleteCharacter;
    }
}