using SQLite;

namespace XamarinForms.SQLite
{
    public class TodoItem
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Text { get; set; }

        public bool Done { get; set; }

        public override string ToString()
        {
            return string.Format("ID : {0}, Done : {1}, Text : {2}", ID, Done, Text);
        }
    }
}