   M S B A M L   `   `   `  ����S  OCS-3280-Group-Assignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CS_3280_Group_AssignmentCS_3280_Group_Assignment  5   	   &     CS_3280_Group_Assignment.wndMain   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:CS_3280_Group_Assignment     5   	     � Title$  wndMain��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   o� -   5        $��mainMenu��5
      $
��Left=�6   $��26��6:   $	��Top=�6F   $��94��6^   .@�5      m� -   5        $��
searchLink��5      $��Search��6)   $��26��69   $��51��6E   6k   m� 5      -   5        $��	itemsLink��5      $��Items��6(   $��26��67   $��43��6C   6h   5      �� 5   
   -   5        $��deleteButton��5      $��Delete Selected Invoice��6%   $
��Left=�6G   $��
83,309,0,0q�6b   $	��Top=�6v   $	��137��6�   6�   �� 5   
   -   5        $��
addInvoice��5      $��Add New Invoice��6#   $
��Left=�6=   $��102,356,0,0q�6X   $	��Top=�6m   $��96��6�   6�   �� 5   
   -   5        $��invoicesLabel��5      $��Invoices��6%   $
��Left=�68   $��	22,81,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $��itemsDataLabel��5      $��Invoice Items��6&   $
��Left=�6>   $��
478,81,0,0q�6Y   $	��Top=�6m   �� 5   
   -   5        $��
itemsLabel��5      $��Items: ��6"   $
��Left=�64   $��301,124,0,0q�6O   $	��Top=�6d   �� 5   
   -	   5        $��itemsComboBox��5      $
��Left=�6(   $��353,128,0,0q�6C   $	��Top=�6X   $	��120��6p   �� 5   
   -
   5        $��addItemButton��5      $��Add item��6&   $
��Left=�69   $��344,222,0,0q�6T   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $��quantityLabel��5      $��
Quantity: ��6%   $
��Left=�6:   $��293,177,0,0q�6U   $	��Top=�6j   �� 5   
   -   5        $��quantityTextBox��5      $
��Left=�6)   $��23��6D   $��353,181,0,0q�6P    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ invoicesDataGrid��5      $
��Left=�6-   $	��189��6H   $��
22,106,0,0q�6U   $	��Top=�6i   $	��266��6�     5   
   -   5        $ invoiceItemsDataGrid��5      $
��Left=�61   $	��189��6L   $��478,107,0,0q�6Y   $	��Top=�6n   $	��292��6�   �� 5   
   -   5         ��Name$ deleteItemButton��5      $��Delete Selected Item��6+   $
��Left=�6J   $��558,309,0,0q�6e   $	��Top=�6z   $	��137��6�   6�   5      5      