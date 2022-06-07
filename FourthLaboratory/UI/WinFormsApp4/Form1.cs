using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClassesLab4;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Assembly assembly;
        IEnumerable<Type> types;
        Type currentType;
        object currentObject;
        MethodInfo currentMethod;
        object[] methodParameters;
        bool isCreateObject = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            assembly = Assembly.Load("LibClassesLab4");
            types = assembly.GetTypes().Where(type => !type.IsAbstract && type.GetInterface("IPhone") != null); 
            class_cmbx.Items.AddRange(types.Select(type => type.Name).ToArray());
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            properties_lbx.Items.Clear();
            method_cmbx.Enabled = true;
            methodExecute_btn.Enabled = false;
            setParameters_btn.Enabled = false;

            MessageBox.Show("Введите объект класса " + currentType.Name);
            object newObject = Activator.CreateInstance(currentType); //создаем объект типа currentType

            Form addForm = constructParametersForm(newObject);

            if (addForm.ShowDialog() == DialogResult.OK)    // если нажата кнопка "ОК" на созданной форме
            {
                PropertyInfo[] properties = newObject.GetType().GetProperties();    //получаем свойства объекта
                for (int i = 1, j = 0; i < addForm.Controls.Count; i += 2, j++) // шагаем по текстбоксам(введенным значениям)
                {
                    string value = addForm.Controls[i].Text;
                    try
                    {
                        if (value.Length != 0)
                        {
                            if (properties[j].PropertyType.Name == "Int32")
                            {
                                properties[j].SetValue(newObject, Int32.Parse(value));
                            }
                            else if (properties[j].PropertyType.Name == "Boolean")
                            {
                                properties[j].SetValue(newObject, Boolean.Parse(value));
                            }
                            else if (properties[j].PropertyType.Name == "Double")
                            {
                                properties[j].SetValue(newObject, Double.Parse(value));
                            }
                            else
                            {
                                properties[j].SetValue(newObject, value);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введён неверный параметр.");
                    }
                }
            }
            isCreateObject = true;
            this.Size = new Size(824, 489);

            //добавляем свойства объекта на главную форму
            currentObject = newObject;
            foreach (PropertyInfo info in currentType.GetProperties())
            {
                properties_lbx.Items.Add(info.Name + ": " + info.GetValue(currentObject));
            }
        }

        private void setParameters_btn_Click(object sender, EventArgs e) //тут все тоже самое только мы считываем параметры а не вводим
        {
            parameters_lbx.Items.Clear();
            if (currentMethod.GetParameters().Length != 0)
            {
                Form enterParamsForm = new Form();
                enterParamsForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                enterParamsForm.MaximizeBox = false;
                enterParamsForm.MinimizeBox = false;
                enterParamsForm.ClientSize = new Size(300, 100);

                int coordinate = 0;
                ParameterInfo[] infos = currentMethod.GetParameters();
                foreach (ParameterInfo info in infos)
                {
                    Label label = new Label { Top = coordinate, Left = 0, Width = enterParamsForm.ClientSize.Width / 2, Height = 20 };
                    label.Text = info.ToString();

                    TextBox textBox = new TextBox { Top = coordinate, Left = label.Width, Width = label.Width, Height = 20 };
                    textBox.Text = "1";

                    enterParamsForm.Controls.Add(label);
                    enterParamsForm.Controls.Add(textBox);
                    coordinate += label.Height + 5;
                }

                enterParamsForm.Controls.Add(new Button() { Top = 50, Left = 100, Width = 100, Height = 50, Text = "Подтвердить" });
                enterParamsForm.Controls[enterParamsForm.Controls.Count - 1].Click += new EventHandler((object sender1, EventArgs e1) => { enterParamsForm.DialogResult = DialogResult.OK; enterParamsForm.Hide(); });
                if (enterParamsForm.ShowDialog() == DialogResult.OK)
                {
                    List<object> parameters = new List<object>();
                    for (int i = 1; i < enterParamsForm.Controls.Count - 1; i += 2)
                    {
                        try
                        {
                            string value = enterParamsForm.Controls[i].Text;
                            if (infos[i / 2].ParameterType == typeof(Int32))
                            {
                                parameters.Add(Int32.Parse(value));
                            }
                            else
                            {
                                parameters.Add(value);
                            }
                            parameters_lbx.Items.Add(enterParamsForm.Controls[i - 1].Text + ": " + value);
                            methodExecute_btn.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Параметр введён неверно.");
                            parameters_lbx.Items.Add(enterParamsForm.Controls[i - 1].Text);
                            methodExecute_btn.Enabled = false;
                        }
                    }
                    methodParameters = parameters.ToArray();
                }
            }
            else
            {
                methodParameters = null;
            }
        }

        private void methodExecute_btn_Click(object sender, EventArgs e)
        {
            if (parameters_lbx.Text.Length == 0 || parameters_lbx.SelectedIndex != -1)
            {
                if (currentMethod.GetParameters().Length != 0 && methodParameters == null)
                {
                    MessageBox.Show("Сначала введите параметры.");
                }
                else //выполняем метод
                {
                    if (currentMethod.ReturnType == typeof(void))
                    {
                        currentMethod.Invoke(currentObject, methodParameters);
                        MessageBox.Show("Метод выполнен.");
                    }
                    else
                    {                        
                        MessageBox.Show(currentMethod.Invoke(currentObject, methodParameters).ToString());
                    }

                    properties_lbx.Items.Clear();
                    foreach (PropertyInfo info in currentType.GetProperties())
                    {
                        properties_lbx.Items.Add(info.Name + ": " + info.GetValue(currentObject));
                    }
                }
            }
            else
            {
                MessageBox.Show("Создайте объект и выберите метод.");
            }
        }

        private void class_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            setParameters_btn.Enabled = false;
            methodExecute_btn.Enabled = false;
            parameters_lbx.Items.Clear();
            properties_lbx.Items.Clear();
            method_cmbx.Items.Clear();

            currentType = types.First(type => type.Name == class_cmbx.SelectedItem.ToString());
            currentObject = null;

            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);
            method_cmbx.Items.AddRange(currentType.GetMethods().Where(method => !objectMethods.Contains(method.Name)
                && !method.Name.Contains("get_") && !method.Name.Contains("set_")).Select(method => method.Name).ToArray());

            method_cmbx.Enabled = false;
            create_btn.Enabled = true;
        }

        private void method_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMethod = currentType.GetMethods().First(method => method.Name == method_cmbx.SelectedItem.ToString());
            methodParameters = null;

            methodExecute_btn.Enabled = false;

            if (currentMethod.GetParameters().Length == 0)
            {
                setParameters_btn.Enabled = false;
                methodExecute_btn.Enabled = currentObject != null;
            }
            else
            {
                setParameters_btn.Enabled = true;
                methodExecute_btn.Enabled = false;
            }

            parameters_lbx.Items.Clear();
            foreach (ParameterInfo info in currentMethod.GetParameters())
            {
                parameters_lbx.Items.Add(info.Name);
            }
        }

        Form constructParametersForm(object currentObject)
        {
            Form addForm = new Form();  //создаем форму и определяем ее свойства
            addForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            addForm.MaximizeBox = false;
            addForm.MinimizeBox = false;
            addForm.ClientSize = new Size(500, 200);

            int coordinate = 0;
            foreach (PropertyInfo info in currentObject.GetType().GetProperties()) //создаем элементы на форме 
            {
                Label label = new Label { Top = coordinate, Left = 0, Width = addForm.ClientSize.Width / 2, Height = 20 };
                label.Text = info.ToString();

                TextBox textBox = new TextBox { Top = coordinate, Left = label.Width, Width = label.Width, Height = 20 };
                textBox.Text = "1";

                addForm.Controls.Add(label);
                addForm.Controls.Add(textBox);
                coordinate += label.Height + 5;
            }

            addForm.Controls.Add(new Button() { Top = 150, Left = 130, Width = 100, Height = 50, Text = "ОК" });
            addForm.Controls[addForm.Controls.Count - 1].Click += new EventHandler((object sender2, EventArgs e2) => { addForm.DialogResult = DialogResult.OK; addForm.Close(); });

            return addForm;
        }
    }
}