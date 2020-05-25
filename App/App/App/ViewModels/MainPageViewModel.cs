﻿using App.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.ViewModels
{
	public class MainPageViewModel : NotificationObject
    {
		private ObservableCollection<Survey> surveys;

		public ObservableCollection<Survey> Surveys
		{
			get { return surveys; }
			set
			{
				surveys = value;
				OnPropertyChanged();
			}
		}

		public ICommand AddCommand { get; set; }

		public MainPageViewModel()
		{
			Surveys = new ObservableCollection<Survey>();

			AddCommand = new Command(AddCommandExecute);

			MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", (a, s) =>
			{
				Surveys.Add(s);
			});
		}

		private void AddCommandExecute(object obj)
		{
			MessagingCenter.Send(this, "AddSurvey");
		}
	}
}
