

namespace DesignePatterns.CreationalPatterns.Prototype
{
    public class Person : IPrototype<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person Clone()
        {
            // کپی سطحی (Shallow copy) - برای نمونه‌های ساده کافی است
            return (Person)this.MemberwiseClone();
        }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
