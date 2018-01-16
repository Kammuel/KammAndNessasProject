namespace CharacterSheet
{
    partial class frmStats
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
            this.numStrength = new System.Windows.Forms.NumericUpDown();
            this.numWisdom = new System.Windows.Forms.NumericUpDown();
            this.numIntelligence = new System.Windows.Forms.NumericUpDown();
            this.numCharisma = new System.Windows.Forms.NumericUpDown();
            this.numFortitude = new System.Windows.Forms.NumericUpDown();
            this.numDexterity = new System.Windows.Forms.NumericUpDown();
            this.Strength = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewCharName = new System.Windows.Forms.TextBox();
            this.txtPointsLeft = new System.Windows.Forms.TextBox();
            this.btnSaveCharacter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFortitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).BeginInit();
            this.SuspendLayout();
            // 
            // numStrength
            // 
            this.numStrength.Location = new System.Drawing.Point(163, 39);
            this.numStrength.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numStrength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numStrength.Name = "numStrength";
            this.numStrength.ReadOnly = true;
            this.numStrength.Size = new System.Drawing.Size(120, 20);
            this.numStrength.TabIndex = 0;
            this.numStrength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numStrength.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatsChanged);
            // 
            // numWisdom
            // 
            this.numWisdom.Location = new System.Drawing.Point(163, 79);
            this.numWisdom.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numWisdom.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numWisdom.Name = "numWisdom";
            this.numWisdom.ReadOnly = true;
            this.numWisdom.Size = new System.Drawing.Size(120, 20);
            this.numWisdom.TabIndex = 1;
            this.numWisdom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWisdom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatsChanged);
            // 
            // numIntelligence
            // 
            this.numIntelligence.Location = new System.Drawing.Point(163, 119);
            this.numIntelligence.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numIntelligence.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numIntelligence.Name = "numIntelligence";
            this.numIntelligence.ReadOnly = true;
            this.numIntelligence.Size = new System.Drawing.Size(120, 20);
            this.numIntelligence.TabIndex = 2;
            this.numIntelligence.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numIntelligence.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatsChanged);
            // 
            // numCharisma
            // 
            this.numCharisma.Location = new System.Drawing.Point(163, 159);
            this.numCharisma.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numCharisma.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numCharisma.Name = "numCharisma";
            this.numCharisma.ReadOnly = true;
            this.numCharisma.Size = new System.Drawing.Size(120, 20);
            this.numCharisma.TabIndex = 3;
            this.numCharisma.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCharisma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatsChanged);
            // 
            // numFortitude
            // 
            this.numFortitude.Location = new System.Drawing.Point(163, 199);
            this.numFortitude.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numFortitude.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFortitude.Name = "numFortitude";
            this.numFortitude.ReadOnly = true;
            this.numFortitude.Size = new System.Drawing.Size(120, 20);
            this.numFortitude.TabIndex = 4;
            this.numFortitude.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFortitude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatsChanged);
            // 
            // numDexterity
            // 
            this.numDexterity.Location = new System.Drawing.Point(163, 239);
            this.numDexterity.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numDexterity.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numDexterity.Name = "numDexterity";
            this.numDexterity.ReadOnly = true;
            this.numDexterity.Size = new System.Drawing.Size(120, 20);
            this.numDexterity.TabIndex = 5;
            this.numDexterity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDexterity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatsChanged);
            // 
            // Strength
            // 
            this.Strength.AutoSize = true;
            this.Strength.Location = new System.Drawing.Point(35, 41);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(47, 13);
            this.Strength.TabIndex = 6;
            this.Strength.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wisdom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Intelligence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Charisma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fortitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dexterity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Points Left";
            // 
            // txtNewCharName
            // 
            this.txtNewCharName.Location = new System.Drawing.Point(12, 8);
            this.txtNewCharName.Name = "txtNewCharName";
            this.txtNewCharName.ReadOnly = true;
            this.txtNewCharName.Size = new System.Drawing.Size(100, 20);
            this.txtNewCharName.TabIndex = 15;
            // 
            // txtPointsLeft
            // 
            this.txtPointsLeft.Location = new System.Drawing.Point(94, 275);
            this.txtPointsLeft.Name = "txtPointsLeft";
            this.txtPointsLeft.Size = new System.Drawing.Size(100, 20);
            this.txtPointsLeft.TabIndex = 16;
            // 
            // btnSaveCharacter
            // 
            this.btnSaveCharacter.Location = new System.Drawing.Point(213, 272);
            this.btnSaveCharacter.Name = "btnSaveCharacter";
            this.btnSaveCharacter.Size = new System.Drawing.Size(103, 23);
            this.btnSaveCharacter.TabIndex = 17;
            this.btnSaveCharacter.Text = "Save Character";
            this.btnSaveCharacter.UseVisualStyleBackColor = true;
            this.btnSaveCharacter.Click += new System.EventHandler(this.btnSaveCharacter_Click);
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 310);
            this.Controls.Add(this.btnSaveCharacter);
            this.Controls.Add(this.txtPointsLeft);
            this.Controls.Add(this.txtNewCharName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.numDexterity);
            this.Controls.Add(this.numFortitude);
            this.Controls.Add(this.numCharisma);
            this.Controls.Add(this.numIntelligence);
            this.Controls.Add(this.numWisdom);
            this.Controls.Add(this.numStrength);
            this.Name = "frmStats";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFortitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStrength;
        private System.Windows.Forms.NumericUpDown numWisdom;
        private System.Windows.Forms.NumericUpDown numIntelligence;
        private System.Windows.Forms.NumericUpDown numCharisma;
        private System.Windows.Forms.NumericUpDown numFortitude;
        private System.Windows.Forms.NumericUpDown numDexterity;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewCharName;
        private System.Windows.Forms.TextBox txtPointsLeft;
        private System.Windows.Forms.Button btnSaveCharacter;
    }
}