   M S B A M L   `   `   `  ����E  ALab2_UI_V2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Lab2_UI_V2
Lab2_UI_V2  5   	       Lab2_UI_V2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Lab2_UI_V2     5   	   -   5          � Title$  
Lab2_UI_V2��5   	   $	��500��6   $	��900��6)    � 	Resources 5         key_view_DataCollection �� Source  key_view_DataOnGrid  Details �� Path��%f  &	        &	 7     &	 n     �� 5   
   -   5         5       �� 5   @   �� 5   
   -   5         5       �� 5   <   �� 5   
   .R�5      �� $��5q�6   .+�5      �� $��12(�6   $
��Left=�6G   ��6*   �� $ Vector�6G   �� 5      $��12(�6   $
��Left=�6H   ��6*   �� $ Complex�6H   5      5      5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Open��5      5         5"   
   -   5        $ ApplicationCommands.Save��5"      5$        5&   
   -   5           Lab2_UI_V2.MainWindow   AddDataItem# Z 5&      5(        5*   
   -   5        $  ApplicationCommands.Delete��5*      5,      .��50      �  � RowDefinitions 51   
   �� 52      $	��94* �6   �� 53      $
��391* �6   .+�55   
   �� $��0��56      $��Stretch=�57      $	��Top=�58      $��11,313,-11,0q�6/   $��1��6E   �� 5:   
   $��0��6   $��Center=�5;      $��2��64   o� 5=   
   -   5         o�Name$
 File��5=      $��20(�6   $	��Top=�6+   $
��Left=�6J   $��46��6e   $	��Top=�6q   .@�5>      m� $
��File��6   $��46��6%   .@�5?      m� -	   5        	 m�Name$	 New_btn��5?      $	��New��6,   69   m� 5@      -
   5        $	 Open_btn��5@      $
��Open��6-   
 m� Command$
 ApplicationCommands.Open��6;    m� CommandParameter$ From Button��6^   m� 5A      -   5        $	 Save_btn��5A      $
��Save��6-   $
 ApplicationCommands.Save��6;   $ From Button��6^   5B      5C      o� 5E   
   -   5        $
 Edit��5E      $��20(�6   $	��Top=�6+   $
��Left=�6J   $��46,0,0,0q�6e   $��46��6w   $	��Top=�6�   .@�5F      m� $
��Edit��6   $��46��6%   .@�5G      m� -   5        $	 
AddDef_btn��5G      $��Add Defaults��6/   6E   m� 5H      -   5        $	 AddDefDC_btn��5H      $"��Add Default V2DataCollection��61   6W   m� 5I      -   5        $	 AddDefDOG_btn��5I      $��Add Default V2DataOnGrid��62   6T   m� 5J      -   5        $	 AddElemFile_btn��5J      $��Add Element from File��64   6S   m� 5K      -   5        $	 
Remove_btn��5K      $��Remove��6/   $ 
 ApplicationCommands.Delete��6?   $ From Button��6d   m� 5L      -   5        $	 AddDataItem_btn��5L      $��Add DataItem��64   #
 Z 6J   $ From Button��6|   5M      5N      �� 5P   
   $5��/Main Collection:(Press Crtl to select multiple)��6   $
��Left=�6K   $��
500,25,0,0q�6f   $	��Top=�6z   �� 5Q   
   -   5         ��Name$ listBox_Main��5Q       �� SelectionMode$ Extended=�6(   $��500,40,55,300q�5S      $��2��6)   ��5R      �� 5S   )   �� 5U   
   $
��Left=�6   $��
40,110,0,0q�6/   $	��Top=�6C   $��1��6[   �� 6i   $�V2 Data Collection:��6m   �� 6�   �� 6�   6�   �� 5V   
   -   5        $ listBox_DataCollection��5V      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5X      $��40,125,510,122q�5Y      $��1��6*   ��5W      ��  �� Source# [  5Y   *   �� 5[   
   $��Details:��6   $
��Left=�6$   $��500,110,0,0q�6?   $	��Top=�6T   $��1��6l   �� 5\   
   -   5        $ listbox_details��5\      #��[ 5^      $��500,125,55,122q�5_      $��1��6*   ��5]      ��  �� ElementName$ listBox_DataCollection��$ SelectedItem�5_   *   �� 5a   
   $��Average:��6   $
��Left=�6$   $��500,350,0,0q�6?   $	��Top=�6T   $��1��6l   �� 5b   
   -   5         ��Name$ Average��5b      $
��Left=�6%   $��570,350,0,0q�5d      $
��Wrap=�5e      $	��Top=�5f      $��30��5g      $	��250��6    $��1��6,   ��5c      �� $ Average�5g   ,   �� 5i   
   $��Save state:��6   $
��Left=�6'   $��
150,12,0,0q�6B   $	��Top=�6V   �� 5j   
   -   5        $  CollectionChangedAfterSave��5j      $
��Left=�68   $��
150,30,0,0q�5l      $��80��6(   $	��Top=�63   ��5k      �� $  CollectionChangedAfterSave�5l   3   �� 5n   
   $
��Left=�6   $��
40,268,0,0q�6/   $	��Top=�6C   $��1��6[   �� 6j   $�Data On Grid:��6n   �� 6�   �� 6�   6�   �� 5o   
   -   5        $ listBox_DataOnGrid��5o      $��40,283,510,23q�5q      $��1��6)   ��5p      �� # [ 5q   )   �� 5s   
   $��Max on Grid:��6   $
��Left=�6(   $��500,290,0,0q�6C   $	��Top=�6X   $��1��6p   �� 5t   
   $
��Left=�6   $��570,290,0,0q�6/   $	��Top=�6D   $
��Wrap=�5v      $	��250��5w      $��30��6    $��1��6,   ��5u      �� $ listBox_DataOnGrid��$ SelectedItem.Max�5w   ,   �� 5y   
   $��Min on Grid:��6   $
��Left=�6(   $��500,320,0,0q�6C   $	��Top=�6X   $��1��6p   �� 5z   
   $
��Left=�6   $	��Top=�6/   $��570,320,0,0q�6G   $
��Wrap=�5|      $��30��5}      $	��250��6    $��1��6,   ��5{      �� $ listBox_DataOnGrid��$ SelectedItem.Min�5}   ,   �� 5   
   $��X coordinate:��6   $
��Left=�6)   $��40,0,0,0q�6D   $	��Top=�6V   $��1��6n   �� 5�   
   -   5         ��Name$ 	TextBox_X��5�      $
��Left=�5�      $	��Top=�6-   $��	125,0,0,0q�6E    �� TextWrapping$
 Wrap=�5�      $	��265��6&   $��1��62   ��5�      �� $ X� �� ValidatesOnDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�5�   2   �� 5�   
   $��Y coordinate:��6   $
��Left=�6)   $��	40,25,0,0q�6D   $	��Top=�6W   $��1��6o   �� 5�   
   -   5        $ 	TextBox_Y��5�      $
��Left=�5�      $	��Top=�6-   $��
125,25,0,0q�6E   $
 Wrap=�5�      $	��265��6&   $��1��62   ��5�      �� $ Y�$
 True��$ PropertyChanged=�5�   2   �� 5�   
   $��
Real Part:��6   $
��Left=�6&   $��	40,50,0,0q�6A   $	��Top=�6T   $��1��6l   �� 5�   
   -   5        $ TextBox_Real��5�      $
��Left=�5�      $	��Top=�6-   $��
125,50,0,0q�6E   $
 Wrap=�5�      $	��265��6&   $��1��62   ��5�      �� $
 Real�$
 True��$ PropertyChanged=�5�   2   �� 5�   
   $��Imagine Part:��6   $
��Left=�6)   $��	40,75,0,0q�6D   $	��Top=�6W   $��1��6o   �� 5�   
   -   5        $ TextBox_Imagine��5�      $
��Left=�5�      $	��Top=�6-   $��
125,75,0,0q�6E   $
 Wrap=�5�      $	��265��6&   $��1��62   ��5�      �� $ Imagine�$
 True��$ PropertyChanged=�5�   2   c� 5�   
   $
��Left=�6   $
��Auto��6-   $��	90,55,0,0q�6;   $	��Top=�6N   $	��250��6f   .@�5�      �� $
��Open��6   $��ApplicationCommands.Open��6$   $��From Button��6G   �� 5�      $
��Save��6   $��ApplicationCommands.Save��6$   $��From Button��6G   �� 5�      $��Add DataItem��6   #��Z 6,   $��From Button��6^   �� 5�      $��Remove��6   $ ��ApplicationCommands.Delete��6&   $��From Button��6K   5�      5�      5�      