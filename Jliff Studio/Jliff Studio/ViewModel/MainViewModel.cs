using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using System.Xml.Serialization;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using JliffStudio.Xliff;
using Microsoft.Win32;
using PropertyChanged;

namespace JliffStudio.ViewModel
{
    [ImplementPropertyChanged]
    public class MainViewModel : ViewModelBase
    {
        public List<string> NotePriorities { get; set; }
        public ICommand OpenCommand { get; set; }
        public Note SelectedNote { get; set; }
        public TranslationUnit SelectedTranslationUnit { get; set; }
        public ICommand SelectedTranslationUnitChangedCommand { get; set; }
        public List<string> TranslationUnitStateQualifiers { get; set; }
        public List<string> TranslationUnitStates { get; set; }

        public Document XliffDocument { get; set; }

        /// <summary>
        ///     Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            TranslationUnitStates = new List<string>
            {
                "Translation pending",
                "Translated",
                "Review pending",
                "Approval pending",
                "Approved"
            };
            TranslationUnitStateQualifiers = new List<string> { "Suggestion", "Trademark" };
            NotePriorities = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            if (!IsInDesignMode)
            {
                OpenCommand = new RelayCommand(() =>
                {
                    var dialog = new OpenFileDialog();
                    dialog.Multiselect = false;

                    if (dialog.ShowDialog() == true)
                    {
                        var serializer = new XmlSerializer(typeof (Document));
                        using (var reader = new StreamReader(dialog.FileName))
                        {
                            XliffDocument = (Document) serializer.Deserialize(reader);
                        }
                    }
                });
                SelectedTranslationUnitChangedCommand = new RelayCommand(() =>
                {
                    // TODO load translations from services available (i.e.: Google Translate, Microsoft Translator, etc.)
                });
            }
        }
    }
}