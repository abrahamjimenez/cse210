﻿using System;
namespace Learning04
{
	public class Assignment
	{
		private string _studentName;
		private string _topic;

        public Assignment()
		{

		}

		public void SetStudentName(string name)
		{
			_studentName = name;
		}

		public void SetTopic(string topic)
		{
			_topic = topic;
		}

		public string GetSummary()
		{
			return $"{_studentName} - {_topic}";
		}
	}
}

