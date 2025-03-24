using System;
using System.Collections;

//class Program
//{
//    public static void Main(string[] args)
//    {
//        string name = "Darshan";
//        string uni = " University ";

//        //length of string
//        Console.WriteLine($"Length of {name} : "+name.Length);
//        Console.WriteLine($"Length of {uni}  : " + uni.Length);

//        Console.WriteLine("String 1 in Upper Case : " + name.ToUpper());
//        Console.WriteLine("String 1 in Lower Case : " + uni.ToLower());

//        //join tow string
//        string joinedStr = string.Concat(name, uni);
//        joinedStr = string.Concat(joinedStr, "Rajkot");
//        Console.WriteLine("Joined String name and uni: " + joinedStr);


//        //compare string
//        Boolean result1 = name.Equals(uni);
//        Console.WriteLine(result1);

//        //use the escape character
//        string str = "This is the \"String\" demo";
//        Console.WriteLine(str);

//        //check if string contain "shan"
//        bool check = name.Contains("shan");
//        Console.WriteLine("String uni containes your given string ? trueor false : "+check);


//        //substrig
//        Console.WriteLine("Substring from the name : " + name.Substring(3));
//        Console.WriteLine("Substring from the uni : "+ uni.Substring(2));
//        Console.WriteLine("Substring from the uni : " + uni.Substring(0,9));

//        //return -1 becceuse darhsn comes before uni
//        //in alphabetical ored
//        Console.WriteLine("Compare name the uni : " + String.Compare(name, uni));

//        //compareTo
//        Console.WriteLine("CompareTo name the uni : " + uni.CompareTo(name));


//        //insert
//        Console.WriteLine("insert sting : " + name.Insert(0, "Welcome to "));

//        //lastindexOF
//        Console.WriteLine("last index of sting : " + uni.LastIndexOf("s"));

//        //remove
//        Console.WriteLine("remove string : " + name.Remove(5));

//        //replace
//        Console.WriteLine("replace sting : " + uni.Replace("y","Y"));


//        //cloan
//        Console.WriteLine("Clone : " + name.Clone());

//        //endswith
//        Console.WriteLine("Ends with trueor false??: " + uni.EndsWith("t"));

//        //equals
//        Console.WriteLine("name is equals uni ?? : " + uni.Equals(name));

//        //index of
//        Console.WriteLine("index of firts occourece  of given string: " + name.IndexOf("a"));

//        //start with
//        Console.WriteLine(" is String is start with your given char?? : " + uni.StartsWith("D"));

//        //trim
//        Console.WriteLine("trim : " +joinedStr.Trim());
//        Console.WriteLine("trim start : " + joinedStr.TrimStart());
//        Console.WriteLine("trim  end: " + joinedStr.TrimEnd());

//    }
//}



class Program
{
    public static void Main(string[] args)
    {
        Console.Write("please enter the number to divide by 100 : ");
        try
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 100 / num;
            Console.WriteLine("100 / {0} = {1}", num, result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero, please try again.");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Invalide Opration, please try again.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Not valid formate, please try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred, please try again.");
        }
    }
}

