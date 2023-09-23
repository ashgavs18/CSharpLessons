using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daythree
{
    internal interface IMessageService
    {
        //interface is not class it doesnt have objects
        // interface must be implemented
        // interface need not to be public
        // interface class starts with I
        //if there two or more abstract method in multiple class
        // child inherits from those method
        // implement of interfcae
        //inherit should done only if we do overriding(If u want specilaizaton)
        public void SendMessage(string message);
       public  void SendAudioMessage(string message);
        public void SendVideoMessage(string message);
       public  void ReceiveMessage();
        public void DeleteMessage();
       




    }
    public interface IPayments
    {
        void MakePayment(float amount);
    }

    internal class Whatsapp : IMessageService,IPayments   
    {
        public void DeleteMessage()
        {
            Console.WriteLine("Message deleted");

        }
        public void MakePayment(float amount)
        {
            Console.WriteLine($"Paid Amount{amount}");

        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Method not implemented");

        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendMessage(string message)
        {
           Console.WriteLine("Method not implemented");
        }
        public void SendVideoMessage(string message)
        {
           Console.WriteLine("Method not implemented");

        }
    }
    public class MessageTester
    {
        public static void TestOne()
        {
            IMessageService messageService = new Whatsapp();
            messageService.SendMessage("Hello");
            messageService.ReceiveMessage();
        }
    }

}
