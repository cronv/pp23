﻿using System;
using System.Windows.Forms;
using System.Data.SQLite;
using MaterialSkin.Controls;
using WinForms_TaskList.Forms;
using WinForms_TaskList.Database;
using WinForms_TaskList.Services;
using System.IO;

namespace WinForms_TaskList
{
    public partial class MainForm : MaterialForm
    {
        #region Глобальные переменные
        int openForm = 0;
        AboutForm aboutForm;

        SQLiteConnection connection = new SQLiteConnection(DbConnection.dbConnection);
        #endregion

        public MainForm()
        {
            InitializeComponent();

            //Дефолтная тема
            FormSettings.InstallingDefaultTheme(this, DarkThemeCheckBox);

            DeadLineToDoLabel.Text = DateTime.Now.ToShortDateString();
            DoneText.Text = "Нет";
        }       

        #region Выбор темы офрмления при установки галочки
        private void DarkThemeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FormSettings.ChoosingAppTheme(DarkThemeCheckBox);
        }
        #endregion

        #region Открытие окна с ифнормации о приложении с дополнительной проверкой
        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "AboutForm")
                    openForm = 1;
                else
                    openForm = 0;
            }
            if (openForm == 0)
            {
                aboutForm = new AboutForm();
                aboutForm.Show();
            }
        }
        #endregion

        #region Подтверждение закрытия приложения
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageExitForm exitForm = new MessageExitForm();
            exitForm.ShowDialog();

            if (exitForm.DialogResult == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        #endregion

        #region Выбор даты выполнения
        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DeadLineToDoLabel.Text = "";
            DeadLineToDoLabel.Text = e.Start.ToShortDateString();
        }
        #endregion

        #region Загрузка данных
        private void MainForm_Load(object sender, EventArgs e)
        {
            String dbPath;
            if (!Directory.Exists(dbPath = Path.GetDirectoryName(DbConnection.dbPath)))
            {
                Directory.CreateDirectory(dbPath);
                SQLiteConnection.CreateFile(DbConnection.dbPath);

                connection.Open();

                // Migration SQLite
                string createTableQuery = "CREATE TABLE IF NOT EXISTS TaskTable (Id INTEGER PRIMARY KEY AUTOINCREMENT, DateCompletion TEXT, ToDo TEXT, Done TEXT);";
                SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
                connection.Close();
            }

            connection.Open();
            DbController.LoadData(ToDoDataGridView);
            connection.Close();
        }
        #endregion

        #region Обработчики событий

        #region Добавление новых данных в базу
        private void AddDataButton_Click(object sender, EventArgs e)
        {
            DbController.AddNewData(DeadLineToDoLabel, ToDoText, DoneText, ToDoDataGridView);
        }
        #endregion

        #region Редактирование данных
        private void EditDataButton_Click(object sender, EventArgs e)
        {
            DbController.EditData(ToDoDataGridView, DeadLineToDoLabel, ToDoText, DoneText);
        }
        #endregion

        #region Удаление данных
        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            DbController.DeleteData(ToDoDataGridView, DeadLineToDoLabel, ToDoText, DoneText);
        }
        #endregion

        #region Эспорт данных
        private void ExportDataButton_Click(object sender, EventArgs e)
        {
            DbController.ExportDataExcel(ToDoDataGridView);
        }

        #endregion

        #endregion

        #region Вывод сохранённых данных в поля
        private void ToDoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ToDoDataGridView.SelectedRows)
            {
                DeadLineToDoLabel.Text = ToDoDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                ToDoText.Text = ToDoDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                DoneText.Text = ToDoDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        #endregion       
    }
}
