
namespace WinForms_TaskList
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AboutProgramButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExportDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ToDoText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.AddDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ToDoDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCompletionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLineToDoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DarkThemeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.EditDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.DoneText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.Depth = 0;
            this.AboutProgramButton.Location = new System.Drawing.Point(1069, 609);
            this.AboutProgramButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Primary = true;
            this.AboutProgramButton.Size = new System.Drawing.Size(238, 41);
            this.AboutProgramButton.TabIndex = 0;
            this.AboutProgramButton.Text = "О приложении";
            this.AboutProgramButton.UseVisualStyleBackColor = true;
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            // 
            // ExportDataButton
            // 
            this.ExportDataButton.Depth = 0;
            this.ExportDataButton.Location = new System.Drawing.Point(847, 609);
            this.ExportDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportDataButton.Name = "ExportDataButton";
            this.ExportDataButton.Primary = true;
            this.ExportDataButton.Size = new System.Drawing.Size(207, 41);
            this.ExportDataButton.TabIndex = 1;
            this.ExportDataButton.Text = "Экспорт";
            this.ExportDataButton.UseVisualStyleBackColor = true;
            this.ExportDataButton.Click += new System.EventHandler(this.ExportDataButton_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Depth = 0;
            this.DeleteDataButton.Location = new System.Drawing.Point(524, 609);
            this.DeleteDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Primary = true;
            this.DeleteDataButton.Size = new System.Drawing.Size(207, 41);
            this.DeleteDataButton.TabIndex = 2;
            this.DeleteDataButton.Text = "Удалить";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // ToDoText
            // 
            this.ToDoText.Depth = 0;
            this.ToDoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDoText.Hint = "";
            this.ToDoText.Location = new System.Drawing.Point(1122, 425);
            this.ToDoText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ToDoText.Name = "ToDoText";
            this.ToDoText.PasswordChar = '\0';
            this.ToDoText.SelectedText = "";
            this.ToDoText.SelectionLength = 0;
            this.ToDoText.SelectionStart = 0;
            this.ToDoText.Size = new System.Drawing.Size(160, 32);
            this.ToDoText.TabIndex = 3;
            this.ToDoText.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(1043, 380);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(239, 27);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Необходимо сделать:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(1043, 82);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(206, 27);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Дата выполнения:";
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(1048, 118);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 6;
            this.MonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
            // 
            // AddDataButton
            // 
            this.AddDataButton.Depth = 0;
            this.AddDataButton.Location = new System.Drawing.Point(58, 609);
            this.AddDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Primary = true;
            this.AddDataButton.Size = new System.Drawing.Size(207, 41);
            this.AddDataButton.TabIndex = 7;
            this.AddDataButton.Text = "Добавить";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // ToDoDataGridView
            // 
            this.ToDoDataGridView.AllowUserToAddRows = false;
            this.ToDoDataGridView.AllowUserToDeleteRows = false;
            this.ToDoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToDoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.DateCompletionColumn,
            this.ToDoColumn,
            this.DoneColumn});
            this.ToDoDataGridView.Location = new System.Drawing.Point(12, 70);
            this.ToDoDataGridView.Name = "ToDoDataGridView";
            this.ToDoDataGridView.RowHeadersWidth = 62;
            this.ToDoDataGridView.Size = new System.Drawing.Size(962, 428);
            this.ToDoDataGridView.TabIndex = 8;
            this.ToDoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToDoDataGridView_CellClick);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 8;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 140;
            // 
            // DateCompletionColumn
            // 
            this.DateCompletionColumn.DataPropertyName = "DateCompletion";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DateCompletionColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.DateCompletionColumn.HeaderText = "Дата выполнения";
            this.DateCompletionColumn.MinimumWidth = 8;
            this.DateCompletionColumn.Name = "DateCompletionColumn";
            this.DateCompletionColumn.ReadOnly = true;
            this.DateCompletionColumn.Width = 246;
            // 
            // ToDoColumn
            // 
            this.ToDoColumn.DataPropertyName = "ToDo";
            this.ToDoColumn.HeaderText = "Сделать";
            this.ToDoColumn.MinimumWidth = 8;
            this.ToDoColumn.Name = "ToDoColumn";
            this.ToDoColumn.ReadOnly = true;
            this.ToDoColumn.Width = 346;
            // 
            // DoneColumn
            // 
            this.DoneColumn.DataPropertyName = "Done";
            this.DoneColumn.HeaderText = "Выполнено";
            this.DoneColumn.MinimumWidth = 8;
            this.DoneColumn.Name = "DoneColumn";
            this.DoneColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DoneColumn.Width = 195;
            // 
            // DeadLineToDoLabel
            // 
            this.DeadLineToDoLabel.AutoSize = true;
            this.DeadLineToDoLabel.Depth = 0;
            this.DeadLineToDoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.DeadLineToDoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeadLineToDoLabel.Location = new System.Drawing.Point(13, 574);
            this.DeadLineToDoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeadLineToDoLabel.Name = "DeadLineToDoLabel";
            this.DeadLineToDoLabel.Size = new System.Drawing.Size(0, 27);
            this.DeadLineToDoLabel.TabIndex = 9;
            // 
            // DarkThemeCheckBox
            // 
            this.DarkThemeCheckBox.Depth = 0;
            this.DarkThemeCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.DarkThemeCheckBox.Location = new System.Drawing.Point(18, 520);
            this.DarkThemeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.DarkThemeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DarkThemeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkThemeCheckBox.Name = "DarkThemeCheckBox";
            this.DarkThemeCheckBox.Ripple = true;
            this.DarkThemeCheckBox.Size = new System.Drawing.Size(165, 30);
            this.DarkThemeCheckBox.TabIndex = 10;
            this.DarkThemeCheckBox.Text = "Тёмная тема";
            this.DarkThemeCheckBox.UseVisualStyleBackColor = true;
            this.DarkThemeCheckBox.CheckedChanged += new System.EventHandler(this.DarkThemeCheckBox_CheckedChanged);
            // 
            // EditDataButton
            // 
            this.EditDataButton.Depth = 0;
            this.EditDataButton.Location = new System.Drawing.Point(271, 609);
            this.EditDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditDataButton.Name = "EditDataButton";
            this.EditDataButton.Primary = true;
            this.EditDataButton.Size = new System.Drawing.Size(247, 41);
            this.EditDataButton.TabIndex = 12;
            this.EditDataButton.Text = "Редактировать";
            this.EditDataButton.UseVisualStyleBackColor = true;
            this.EditDataButton.Click += new System.EventHandler(this.EditDataButton_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(1043, 515);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(227, 27);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Выполнено (статус):";
            // 
            // DoneText
            // 
            this.DoneText.Depth = 0;
            this.DoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneText.Hint = "";
            this.DoneText.Location = new System.Drawing.Point(1122, 569);
            this.DoneText.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoneText.Name = "DoneText";
            this.DoneText.PasswordChar = '\0';
            this.DoneText.SelectedText = "";
            this.DoneText.SelectionLength = 0;
            this.DoneText.SelectionStart = 0;
            this.DoneText.Size = new System.Drawing.Size(160, 32);
            this.DoneText.TabIndex = 13;
            this.DoneText.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1322, 663);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.DoneText);
            this.Controls.Add(this.EditDataButton);
            this.Controls.Add(this.DarkThemeCheckBox);
            this.Controls.Add(this.DeadLineToDoLabel);
            this.Controls.Add(this.ToDoDataGridView);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.MonthCalendar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ToDoText);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.ExportDataButton);
            this.Controls.Add(this.AboutProgramButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskList App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton AboutProgramButton;
        private MaterialSkin.Controls.MaterialRaisedButton ExportDataButton;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteDataButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField ToDoText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private MaterialSkin.Controls.MaterialRaisedButton AddDataButton;
        private System.Windows.Forms.DataGridView ToDoDataGridView;
        private MaterialSkin.Controls.MaterialLabel DeadLineToDoLabel;
        private MaterialSkin.Controls.MaterialCheckBox DarkThemeCheckBox;
        private MaterialSkin.Controls.MaterialRaisedButton EditDataButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCompletionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoneColumn;
        private MaterialSkin.Controls.MaterialSingleLineTextField DoneText;
    }
}

