   M S B A M L   `   `   `  ����G  CMusicCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:MusicCatalog.Views.CreationWindows"MusicCatalog.Views.CreationWindows  5   	   ?    9MusicCatalog.Views.CreationWindows.PlaylistCreationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:MusicCatalog.Views.CreationWindows     5   	   -   5          � Title$)  #Создание плейлиста��5   	   $	��289��6$   $	��148��61    � 
ResizeMode$ NoResize=�6=    � SizeToContent$ WidthAndHeight=�6S   .��5	      � .+�5
   
   ��    PlaceholderTextBoxStyle#��[  6X   
 � Tag$) #Название плейлиста��6�   $
��Left=�6�   $��10,10,10,10q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��128��6�    �� MaxLines$ 1��6
  ��6   �� *TitleFieldValue+ �� UpdateSourceTrigger$ PropertyChanged=�6
  (  "System.Windows.Controls.DatePicker  5   
   $��Center=�6b   $��0,69,0,0q�6   $	��Top=�6�   $	��128��6�      Text$$ Посл. обновление��6�      SelectedDate 6   �� *DateFieldValue+$ PropertyChanged=�6�   �� 5   
   -   5        $��Добавить трек��5      $��Center=�6)   $��	0,104,0,0q�6F   $	��Top=�6Y   $	��128��6q   6}   �� 5   
   	 �� DisplayMemberPath$	 Designation��6Z   $��10,129,10,38q�6�   $	��106��6�   $	��128��6�   ��6   �� *
TracksList+$ PropertyChanged=�6�   �� 5   
   -   5        $��Создать��5   b   $
��Left=�6t   $��84,240,10,10q�6�   $	��Top=�6�   $��54��6�   ��6   �� *CreateCommand+{�63   �� *CreateCommand.CanExecute+6�   �� 5   
   #��[  6^   $% Краткое описание��6�   $��Center=�6�   $��0,33,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��128��6  
 �� 	MaxLength$
 30��6  $ 1��6  ��6   �� *DescriptionFieldValue+$ PropertyChanged=�6  �� 5   
   $
��Left=�6   $��	10,53,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $$��Посл. обновление��6n   5      5      