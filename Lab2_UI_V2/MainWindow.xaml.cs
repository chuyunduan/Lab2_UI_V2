using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Lab2_UI_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        V2MainCollection mainCollection = new V2MainCollection();

        DataItemChangedEvent binding;

        public static RoutedCommand AddDataItem = new RoutedCommand("Add", typeof(Lab2_UI_V2.MainWindow));

        public MainWindow()
        {
            InitializeComponent();
            DataContext = mainCollection;
        }

        private void DataCollection(object sender, FilterEventArgs args)
        {
            var item = args.Item;
            if (item != null)
            {
                if (item.GetType() == typeof(V2DataCollection)) 
                    args.Accepted = true;
                else args.Accepted = false;
            }
        }

        private void DataOnGrid(object sender, FilterEventArgs args)
        {
            var item = args.Item;
            if (item != null)
            {
                if (item.GetType() == typeof(V2DataOnGrid)) 
                    args.Accepted = true;
                else args.Accepted = false;
            }
        }

        private void AddDef_btn_Click(object sender, RoutedEventArgs e)
        {
            mainCollection.AddDefaults();
        }

        private void AddDefDC_btn_Click(object sender, RoutedEventArgs e)
        {
            mainCollection.AddDefaultDataCollection();
        }

        private void AddDefDOG_btn_Click(object sender, RoutedEventArgs e)
        {
            mainCollection.AddDefaultDataOnGrid();
        }

        private void AddElemFile_btn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "TXTFiles|*.txt";
            if ((bool)dlg.ShowDialog())
                mainCollection.AddElementFromFile(dlg.FileName);
            MessageError();
        }

        //private void Remove_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    var selected = this.listBox_Main.SelectedItems;
        //    if (this.listBox_Main.SelectedItems.Count != 0)
        //    {
        //        List<V2Data> selectedItems = new List<V2Data>();
        //        selectedItems.AddRange(selected.Cast<V2Data>());
        //        foreach (V2Data item in selectedItems)
        //            mainCollection.Remove(item.Info, item.Freq);
        //    }
        //    else
        //    {
        //        mainCollection = new V2MainCollection();
        //        DataContext = mainCollection;
        //    }
        //}

        private bool UnsavedChanges()
        {
            MessageBoxResult mes = MessageBox.Show("Do you want save records?", "Save", MessageBoxButton.YesNoCancel);
            if (mes == MessageBoxResult.Yes)
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "Inf";
                dlg.DefaultExt = ".txt";
                dlg.Filter = "TXTFiles|*.txt";
                if ((bool)dlg.ShowDialog())
                    mainCollection.Save(dlg.FileName);
            }
            else if (mes == MessageBoxResult.Cancel)
                return true;
            return false;
        }

        private void New_btn_Click(object sender, RoutedEventArgs e)
        {
            if (mainCollection.CollectionChangedAfterSave)
                UnsavedChanges();
            mainCollection = new V2MainCollection();
            DataContext = mainCollection;
            MessageError();
        }

        //private void Save_Click(object sender, RoutedEventArgs e)
        //{
        //    Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
        //    dlg.FileName = "Inf";
        //    dlg.DefaultExt = ".txt";
        //    dlg.Filter = "TXTFiles|*.txt";
        //    if ((bool)dlg.ShowDialog())
        //        mainCollection.Save(dlg.FileName);
        //    MessageError();
        //}

        //private void Open_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (mainCollection.CollectionChangedAfterSave)
        //        UnsavedChanges();
        //    Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
        //    if ((bool)dlg.ShowDialog())
        //    {
        //        mainCollection = new V2MainCollection();
        //        mainCollection.Load(dlg.FileName);
        //        DataContext = mainCollection;
        //    }
        //    MessageError();
        //}

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs cl)
        {
            if (mainCollection.CollectionChangedAfterSave)
                cl.Cancel = UnsavedChanges();
            MessageError();
        }

        public void MessageError()
        {
            if (mainCollection.ErrorMessage != null)
            {
                MessageBox.Show(mainCollection.ErrorMessage, "Error");
                mainCollection.ErrorMessage = null;
            }
        }

        private void OpenCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (mainCollection.CollectionChangedAfterSave)
                UnsavedChanges();
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Inf";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "TXTFiles|*.txt";
            if ((bool)dlg.ShowDialog())
                mainCollection.Save(dlg.FileName);
            MessageError();
        }

        private void CanSaveCommandHandler(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mainCollection.CollectionChangedAfterSave;
        }

        private void SaveCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Inf";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "TXTFiles|*.txt";
            if ((bool)dlg.ShowDialog())
                mainCollection.Save(dlg.FileName);
            MessageError();
        }

        private void listBox_DataCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox_DataCollection.SelectedItem as V2DataCollection != null)
            {
                V2DataCollection selected = (V2DataCollection)this.listBox_DataCollection.SelectedItem;
                binding = new DataItemChangedEvent(ref selected);
                TextBox_X.DataContext = binding;
                TextBox_Y.DataContext = binding;
                TextBox_Real.DataContext = binding;
                TextBox_Imagine.DataContext = binding;
            }
        }

        private void CanAddDataItemCommandHandler(object sender, CanExecuteRoutedEventArgs e)
        {
            if (listBox_DataCollection.SelectedItem as V2DataCollection != null)
            {
                if (!(TextBox_X == null || TextBox_Y == null || TextBox_Real == null || TextBox_Imagine == null))
                    if (!(Validation.GetHasError(TextBox_X) || Validation.GetHasError(TextBox_Y)|| Validation.GetHasError(TextBox_Imagine) || Validation.GetHasError(TextBox_Real)))
                    {
                        e.CanExecute = true;
                        return;
                    }
            }
            e.CanExecute = false;
            return;
        }

        private void AddDataItemCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                binding.Add();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }
        }

        private void CanDeleteCommandHandler(object sender, CanExecuteRoutedEventArgs e)
        {
            var selected = this.listBox_Main.SelectedItems;
            List<V2Data> selectedItems = new List<V2Data>();
            selectedItems.AddRange(selected.Cast<V2Data>());

            if (selectedItems.Count != 0)
                e.CanExecute = true;
            else e.CanExecute = false;
        }

        private void DeleteCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            var selected = this.listBox_Main.SelectedItems;
            if (this.listBox_Main.SelectedItems.Count != 0)
            {
                List<V2Data> selectedItems = new List<V2Data>();
                selectedItems.AddRange(selected.Cast<V2Data>());
                foreach (V2Data item in selectedItems)
                    mainCollection.Remove(item.Info, item.Freq);
            }
            else
            {
                mainCollection = new V2MainCollection();
                DataContext = mainCollection;
            }
        }
    }
}