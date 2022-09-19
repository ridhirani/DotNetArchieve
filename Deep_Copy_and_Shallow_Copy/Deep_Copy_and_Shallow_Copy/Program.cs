using System;

namespace Deep_Copy_and_Shallow_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            Copy obj = new Copy();
            Copy objClone = obj;
            obj.I = 458;
            Console.WriteLine("This is Deep copy :ObjClone:{0} is deep copying the obj :{1}", objClone.I, obj.I);
            Copy obj1 = (Copy)obj.Clone();
            obj.I = 4;
            Console.WriteLine("This is Sallow Copy: obj1:{0} is shallow copying the obj:{1}", obj1.I, obj.I);


        }
    }
}
