   M S B A M L   `   `   `  ����G  CMusicCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:MusicCatalog.Views.CreationWindows"MusicCatalog.Views.CreationWindows  5   	   <    6MusicCatalog.Views.CreationWindows.AlbumCreationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   <local0clr-namespace:MusicCatalog.Views.CreationWindows  5   	   -   5          � Title$%  Создание альбома��5	   	   $	��355��6"   $	��152��6/    � 
ResizeMode$ NoResize=�6;    � SizeToContent$ WidthAndHeight=�6Q   .��5
      � .+�5   
   ��    PlaceholderTextBoxStyle#��[  6X   
 � Tag$% Название альбома��6�   $
��Left=�6�   $��10,10,10,10q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��128��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$; 5Имя артиста, название трека...��6   �� MaxLines$ 1��6G  ��6   �� *TitleFieldValue+ �� UpdateSourceTrigger$ PropertyChanged=�6G  �� 5   
    �� DisplayMemberPath$
 Name��6X   $
��Left=�6�   $��	10,49,0,0q�6�   $	��Top=�6�   $	��128��6�   	 �� 
IsEditable$
	 True��6�   
 �� StaysOpenOnEdit$

 True��6�   ��6   �� *	Artists+$ PropertyChanged=� �� SelectedItem 6q   �� *ArtistFieldValue+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ DropDownOpened��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *UpdateArtistsListCommand+5      5      �� 5   
   $
��Left=�6   $��	10,33,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   �� 6o    � Language$ ru-ru�6s   $�Артист��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6b   $��	10,76,0,0q�6}   $	��Top=�6�   $	��128��6�      SelectedDate 6   �� *DateFieldValue+$ PropertyChanged=�6�   �� 5   
   $
 Name��6W   $
��Left=�6�   $��
10,121,0,0q�6�   $	��Top=�6�   $	��128��6�   $
	 True��6�   $

 True��6�   ��6   �� *Genres+$ PropertyChanged=� 6p   �� *GenreFieldValue+ 5        5      $ DropDownOpened��6!   . 5         6,   �� *UpdateGenresListCommand+5      5      �� 5   
   $
��Left=�6   $��
10,105,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ ru-ru�6t   $�Жанр��6�   6�   �� 5   
   $
��Left=�6   $��10,155,10,10q�6/   $
��Wrap=�6E   $	��Top=�6Y   �� 6r   $�Добавление тр��6v   �� 6�   $ ru-ru�6�   $�е��6�   �� 6�   $�ков��6�   6�   �� 5   
   -   5         ��Name$ NewTrackButton��5      $��
Новый��6)   $
��Left=�69   $��
10,171,0,0q�6T   $	��Top=�6h   $��54��6�   6�   �� 5   
   -   5        $ ExistingTrackButton��5      $��Сущ-ий��6.   $
��Left=�6?   $��
83,171,0,0q�6Z   $	��Top=�6n   $��54��6�   6�   �� 5    
   $ Designation��6Z   $��10,196,10,37q�6z   $	��132��6�   $	��106��6�   ��6   �� *
TracksList+$ PropertyChanged=�6�   �� 5!   
   -   5        $��Создать��5!   b   $
��Left=�6t   $��88,307,10,10q�6�   $	��Top=�6�   $��54��6�   ��6   �� *CreateCommand+{�63   �� *CreateCommand.CanExecute+6�   5#      5$      