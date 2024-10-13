namespace SimpleCalculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            MinusPlusBtn = new Button();
            DivideBtn = new Button();
            MinusBtn = new Button();
            ModuloBtn = new Button();
            MultiplyBtn = new Button();
            PlusBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox.Location = new Point(12, 12);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(541, 52);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            TxtBox.TextChanged += textBox1_TextChanged;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            SevenBtn.Location = new Point(43, 125);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(74, 74);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            FourBtn.Location = new Point(43, 205);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(74, 74);
            FourBtn.TabIndex = 2;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            OneBtn.Location = new Point(43, 285);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(74, 74);
            OneBtn.TabIndex = 3;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ZeroBtn.Location = new Point(43, 365);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(74, 74);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            DotBtn.Location = new Point(123, 365);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(74, 74);
            DotBtn.TabIndex = 8;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            TwoBtn.Location = new Point(123, 285);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(74, 74);
            TwoBtn.TabIndex = 7;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            FiveBtn.Location = new Point(123, 205);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(74, 74);
            FiveBtn.TabIndex = 6;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            EightBtn.Location = new Point(123, 125);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(74, 74);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            EqualBtn.Location = new Point(203, 365);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(74, 74);
            EqualBtn.TabIndex = 12;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ThreeBtn.Location = new Point(203, 285);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(74, 74);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            SixBtn.Location = new Point(203, 205);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(74, 74);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            NineBtn.Location = new Point(203, 125);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(74, 74);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            MinusPlusBtn.Location = new Point(366, 365);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(74, 74);
            MinusPlusBtn.TabIndex = 15;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = true;
            MinusPlusBtn.Click += MinusPlusBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            DivideBtn.Location = new Point(366, 285);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(74, 74);
            DivideBtn.TabIndex = 14;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            MinusBtn.Location = new Point(366, 205);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(74, 74);
            MinusBtn.TabIndex = 13;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // ModuloBtn
            // 
            ModuloBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ModuloBtn.Location = new Point(446, 365);
            ModuloBtn.Name = "ModuloBtn";
            ModuloBtn.Size = new Size(74, 74);
            ModuloBtn.TabIndex = 18;
            ModuloBtn.Text = "%";
            ModuloBtn.UseVisualStyleBackColor = true;
            ModuloBtn.Click += ModuloBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            MultiplyBtn.Location = new Point(446, 285);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(74, 74);
            MultiplyBtn.TabIndex = 17;
            MultiplyBtn.Text = "*";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            PlusBtn.Location = new Point(446, 205);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(74, 74);
            PlusBtn.TabIndex = 16;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ClearBtn.Location = new Point(366, 125);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(154, 74);
            ClearBtn.TabIndex = 19;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.att1;
            ClientSize = new Size(565, 489);
            Controls.Add(ClearBtn);
            Controls.Add(ModuloBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(PlusBtn);
            Controls.Add(MinusPlusBtn);
            Controls.Add(DivideBtn);
            Controls.Add(MinusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button MinusPlusBtn;
        private Button DivideBtn;
        private Button MinusBtn;
        private Button ModuloBtn;
        private Button MultiplyBtn;
        private Button PlusBtn;
        private Button ClearBtn;
    }
}