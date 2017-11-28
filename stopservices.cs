using System;
using System.IO;
using System.ServiceProcess;


class Untitled
{
	static void Main(string[] args)
	{
		ServiceController service1 = new ServiceController("Rabbit");
		service1.Stop();
		//Stops desired services, outputs this to the username and saves the output
		Console.WriteLine("{0}", service1);
		DateTime RestartDatetime = DateTime.Now;
		string serviceStoppedlogfile = "";
		System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", serviceStoppedlogfile);

		//Restarts desired services, outputs this to the username and saves the output
		if(service1.Status.Equals(ServiceControllerStatus.Stopped))
		{
			string usersRespones ="";
			Console.WriteLine("Would you wish to restart the services? Y'N");
			Console.ReadLine(usersRespones);
			if(usersRespones == "Y";)
			{
				service1.Start();
				Console.WriteLine("Restarting services")
				RestartDatetime = Datetime.Now;
				string serviceRestartlogfile = "";
				System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", serviceRestartlogfile);
			}
			else
			{
				Console.WriteLine("Ok. Thankyou");
			}
		}
		//
		
	}
}