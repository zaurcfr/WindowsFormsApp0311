namespace WindowsFormsApp0311
{
    class Car
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public static int id = 100;
        public Car()
        {
            ID = ++id;
        }
    }
}