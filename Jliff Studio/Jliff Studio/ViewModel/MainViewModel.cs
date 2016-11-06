using System.IO;
using System.Windows.Input;
using System.Xml.Serialization;
using GalaSoft.MvvmLight;
using JliffStudio.Models;
using Microsoft.Win32;
using GalaSoft.MvvmLight.Command;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using JliffStudio.Properties;

namespace JliffStudio.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (!IsInDesignMode)
            {
                OpenCommand = new RelayCommand(() =>
                {
                    var dialog = new OpenFileDialog();
                    dialog.Multiselect = false;

                    if (dialog.ShowDialog() == true)
                    {
                        var serializer = new XmlSerializer(typeof (Xliff));
                        using (var reader = new StreamReader(dialog.FileName))
                        {
                            Xliff = (Xliff) serializer.Deserialize(reader);
                        }
                    }
                });
                SelectedTranslationUnitChangedCommand = new RelayCommand(() =>
                {
                    // TODO load translations from services available (i.e.: Google Translate, Microsoft Translator, etc.)
                });
            }
        }

        public Xliff Xliff { get; set; }
        public TranslationUnit SelectedTranslationUnit { get; set; }
        public ICommand OpenCommand { get; set; }
        public ICommand SelectedTranslationUnitChangedCommand { get; set; }
    }
}