   M S B A M L   `   `   `  ����F  BCard Editor, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null)clr-namespace:Card_EditorCard_Editor  5   	       Card_Editor.CardBrowser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Card_Editor     5   	   -   5          � Title$  CardBrowser��5   	   $	��600��6   $	��500��6*   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ cardGrid��5
      $
��Left=�6%   $	��532��6@   $	��Top=�6M   $	��472��6e   $��10,0,0,0q�6q   �� 5   
   -   5         ��Name$ 
openButton��5      $
��Open��6%   $
��Left=�64   $��
10,540,0,0q�6O   $	��Top=�6c   $��75��6{   �� 5   
   -   5        $ deleteButton��5      $��Delete��6'   $
��Left=�68   $��103,540,0,0q�6S   $	��Top=�6h   $��75��6�   �� 5   
   -   5        $ cancelButton��5      $��Cancel��6'   $
��Left=�68   $��407,539,0,0q�6S   $	��Top=�6h   $��75��6�   6�   5      5      