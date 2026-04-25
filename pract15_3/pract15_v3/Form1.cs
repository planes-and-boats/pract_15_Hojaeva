using System.Collections;

namespace pract15_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList vectors = new ArrayList();
        static private void UpdateList(ArrayList arrayList, ListBox list)
        {
            list.Items.Clear();
            if (arrayList.Count > 0)
            {
                foreach (Vector3D vector in arrayList)
                {
                    list.Items.Add(vector.ToString().ToString());
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbX.Text, out double X) && double.TryParse(tbY.Text, out double Y) && double.TryParse(tbZ.Text, out double Z))
            {
                Vector3D v = new(X, Y, Z);
                vectors.Add(v);
                UpdateList(vectors, listBox1);
            }
            else
            {
                MessageBox.Show("Введите все данные корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb1.Text, out int ind1) && int.TryParse(tb2.Text, out int ind2))
            {
                if (ind1 > 0 && ind1 <= vectors.Count && ind2 > 0 && ind2 <= vectors.Count)
                {
                    Vector3D result = Vector3D.Add((Vector3D)vectors[ind1 - 1], (Vector3D)vectors[ind2 - 1]);
                    vectors.Add(result);
                    MessageBox.Show($"Результат сложения: {result}", "Новый вектор", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateList(vectors, listBox1);
                }
                else
                {
                    MessageBox.Show("Введите номера в пределах листа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb1.Text, out int ind1) && int.TryParse(tb2.Text, out int ind2))
            {
                if (ind1 > 0 && ind1 <= vectors.Count && ind2 > 0 && ind2 <= vectors.Count)
                {
                    Vector3D result = Vector3D.Subtract((Vector3D)vectors[ind1 - 1], (Vector3D)vectors[ind2 - 1]);
                    vectors.Add(result);
                    MessageBox.Show($"Результат вычитания: {result}", "Новый вектор", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateList(vectors, listBox1);
                }
                else
                {
                    MessageBox.Show("Введите номера в пределах листа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb1.Text, out int ind1) && int.TryParse(tb2.Text, out int ind2))
            {
                if (ind1 > 0 && ind1 <= vectors.Count && ind2 > 0 && ind2 <= vectors.Count)
                {
                    double result = Vector3D.Multiply((Vector3D)vectors[ind1 - 1], (Vector3D)vectors[ind2 - 1]);
                    MessageBox.Show($"Результат произведения: {result}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Введите номера в пределах листа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonKos_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb1.Text, out int ind1) && int.TryParse(tb2.Text, out int ind2))
            {
                if (ind1 > 0 && ind1 <= vectors.Count && ind2 > 0 && ind2 <= vectors.Count)
                {
                    double result = Vector3D.CosAngle((Vector3D)vectors[ind1 - 1], (Vector3D)vectors[ind2 - 1]);
                    MessageBox.Show($"Косинус угла между векторами: {Math.Round(result, 2)}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Введите номера в пределах листа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonMaxL_Click(object sender, EventArgs e)
        {
            if (vectors.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var maxVector = vectors.Cast<Vector3D>()
                               .OrderByDescending(v => v.Length())
                               .FirstOrDefault();
                MessageBox.Show($"Самый длинный вектор: {maxVector}", "LINQ Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (vectors.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Vector3D vector in vectors)
                {
                    listBox2.Items.Add(Math.Round(vector.Length(), 2));
                }
            }
        }
    }
}
