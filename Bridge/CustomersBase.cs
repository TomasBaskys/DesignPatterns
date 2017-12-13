using System;

namespace Bridge
{
    public class CustomersBase
    {
        public DataObject Data { get; set; }

        protected string _group;

        public CustomersBase(string group)
        {
            _group = group;
        }

        public virtual void Next()
        {
            Data.NextRecord();
        }

        public virtual void Prior()
        {
            Data.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            Data.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            Data.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            Data.ShowRecord();
        }

        public virtual void ShowAll()
        {
            Console.WriteLine($"Customer Group: {_group}");
            Data.ShowAllRecords();
        }
    }
}