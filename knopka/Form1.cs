using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PhotoViewerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем путь к папке, в которой находится исполняемый файл приложения
            string executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Складываем путь к изображению относительно этой папки
            string imagePathRelativeToExecutable = Path.Combine("Images", "image.jpg");

            // Полный путь к изображению
            string imagePath = Path.Combine(executablePath, imagePathRelativeToExecutable);

            try
            {
                // Проверяем, что файл существует
                if (File.Exists(imagePath))
                {
                    // Загрузка изображения и установка в PictureBox
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Файл изображения не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получаем путь к папке, в которой находится исполняемый файл приложения
            string executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Складываем путь к изображению относительно этой папки
            string imagePathRelativeToExecutable = Path.Combine("Images", "kot.jpg");

            // Полный путь к изображению
            string imagePath = Path.Combine(executablePath, imagePathRelativeToExecutable);

            try
            {
                // Проверяем, что файл существует
                if (File.Exists(imagePath))
                {
                    // Загрузка изображения и установка в PictureBox
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Файл изображения не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получаем путь к папке, в которой находится исполняемый файл приложения
            string executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Складываем путь к изображению относительно этой папки
            string imagePathRelativeToExecutable = Path.Combine("Images", "busick.jpg");

            // Полный путь к изображению
            string imagePath = Path.Combine(executablePath, imagePathRelativeToExecutable);

            try
            {
                // Проверяем, что файл существует
                if (File.Exists(imagePath))
                {
                    // Загрузка изображения и установка в PictureBox
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Файл изображения не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
            }
        }
    }
}