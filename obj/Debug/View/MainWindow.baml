   M S B A M L   `   `   `  ����@  <trpz3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:mvvc_wpfmvvc_wpf  5   	       mvvc_wpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:mvvc_wpf     5   	     � Title$  
MainWindow��5   	   $��446.8��6   $��349.334��6+   .��5	      � $��0,0,-5.8,0.4q�6    � ColumnDefinitions 5
   
   �� 5      $
��172* �6   �� 5      $
��177* �6   .+�5   
   �� $��Ім'я��6   $
��Left=�6   $��4,4,0,0q�6:   $	��Top=�6K   �� 5   
   -   5        $
��Name��5      $
��Left=�6:   $��32��6U   $��39,4,0,0q�6a    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��128��6�   ��6    �� *	Сustomer+6�   �� 5   
   $��Замовити��6   $
��Left=�6C   $��	14,10,0,0q�6^   $	��Top=�6q   $	��114��6�   $��1��6�   ��6$   �� *
AddCommand+6�   �� 5   
   -   5        $��listBox_storage��5      $��0��6)   $��0��69   $��4,41,5.8,190.4q�5   ;    J� RenderTransformOrigin$ 0.5,0.5&�6S   $��2��6s   ��5   F   �� *
Storages+ �� SelectedItem 5      �� *SelectedStorage+��5      �� 5      .R�5      �� $��5q�6!   .+�5      �� $��18(�6$   ��62   ��  �� Path$
 Name��� 5      $��18(�6$   ��62   �� $ Distance�5      5      5      �� 5   
   -   5        $��listBox_good��5      $��0��6&   $��0��66   $��4,0,5.8,0.4q�5    8   $ 0.5,0.5&�6M   $��2��6m   $	��185��6�   $��Bottom=�6�   ��5   C   �� *Goods+ 5       �� *SelectedGood+��5!      �� 5"      .R�5#      �� $��5q�6!   .+�5$      �� $��18(�6$   ��62   �� $
 Name��� 5%      $��18(�6$   ��62   �� $ ExecutionTime�5&      5'      5)      5*      5+      