using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            User myUser = new User();

            myUser.UserName = "Antonio";
            myUser.TotalViews = 2;
            myUser.Likes = 3;

            myUser.Comments = new List<string>();
            myUser.Comments.Add("This is the first comment.");
            myUser.Comments.Add("A great comment.");
            myUser.Comments.Add("The last comment.");

            Console.WriteLine("The User " + myUser.UserName +
                " has Total Views of: " + myUser.TotalViews +
                " , With these many likes: " + myUser.Likes);


            Console.WriteLine("It has the following comments:");
            foreach(var item in myUser.Comments)
            {
                Console.WriteLine(item);
            }

        }
    }
}
public class User
{
    public string UserName { get; set; }
    public int TotalViews { get; set; }
    public int Likes { get; set; }
    public List<string> Comments { get; set; } 
}
