using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using year_12_Redo;

namespace year_12_Redo
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		public static Student LoggedStudent = new Student();
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
		public static bool challengeComplete = false;
		public static int quizResult = 0;
		public static int ReactionTestScore = 0;
		public static int questionsCompleted = 0;
	
		public static int TotalScore = 0;
		public static void RandomizeList<T>(IList<T> list)
		{
			Random r = new Random();

			for (int i = 0; i < list.Count - 1; i++)
			{
				int j = r.Next(i, list.Count);
				T temp = list[i];
				list[i] = list[j];
				list[j] = temp;
			}
		}
		public static void WriteToFile(List<Student> studentList)
		{
			string path = Path.GetFullPath("UserDetails.txt");
			MessageBox.Show($"Saving {studentList.Count} students to:\n{path}");

			try
			{
				Student s = studentList[studentList.Count - 1];   // the newest student
				string line = $"{s.Username},{s.Password},{s.Avatar},{s.Year}";
				File.AppendAllLines("UserDetails.txt", new[] { line });
				MessageBox.Show("Save finished");
			}
			
			catch (Exception e)
			{
				MessageBox.Show("Error: " + e.Message);
			}
		}

		public static void ReadFromFile(List<Student> studentList)
		{
			studentList.Clear();   // avoid duplicates if called more than once

			try
			{
				if (!File.Exists("UserDetails.txt"))
					return;

				foreach (string line in File.ReadAllLines("UserDetails.txt"))
				{
					if (string.IsNullOrWhiteSpace(line))
						continue;

					string[] parts = line.Split(',');
					if (parts.Length != 4)
						continue;

					studentList.Add(new Student
					{
						Username = parts[0],
						Password = parts[1],
						Avatar = parts[2],
						Year = parts[3]
					});
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Error loading file: " + e.Message);
			}
		}

	}

}
//var lines = studentList.Select(p => $"{p.Username},{p.Password},{p.Avatar}");
//File.WriteAllLines("UserDetails.txt", lines);

