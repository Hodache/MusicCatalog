   M S B A M L   `   `   `  ����G  CMusicCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:MusicCatalog.Views.CreationWindows"MusicCatalog.Views.CreationWindows  5   	   M+clr-namespace:MusicCatalog.Views.ConvertersMusicCatalog.Views.Converters  5   	   <    6MusicCatalog.Views.CreationWindows.TrackCreationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   <local0clr-namespace:MusicCatalog.Views.CreationWindows  5   	   <
converters+clr-namespace:MusicCatalog.Views.Converters  5   	     � Title$!  Создание трека��5
   	   $	��287��6    $	��153��6-    � 
ResizeMode$ NoResize=�69    � SizeToContent$ WidthAndHeight=�6O    � 	Resources 5      8   2MusicCatalog.Views.Converters.StringToIntConverter   StringToIntConverter��%   &	          5   
   6*   5      .��5      � .+�5   
   ��   PlaceholderTextBoxStyle#��[ 6X   
 � Tag$! Название трека��6�   $
��Left=�6�   $��10,10,10,10q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��128��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$; 5Имя артиста, название трека...��6   �� MaxLines$ 1��6E  ��6   �� *TitleFieldValue+ �� UpdateSourceTrigger$ PropertyChanged=�6E  �� 5   
   	 �� DisplayMemberPath$
	 Name��62   $��10,121,10,36q�6K   $	��114��6a   $	��133��6n   ��6   �� *	Authors+6n   �� 5   
   -   5        $(��"Создать и добавить��5   j   $��Center=�6�   $��	0,240,0,0q�6�   $	��Top=�6�   $	��133��6�   ��6   �� *AddToAlbumCommand+{�67   �� *AddToAlbumCommand.CanExecute+6�   �� 5   
   #��[ 6�   $( "Длительность (сек.)��6�   $
��Left=�6�   $��10,33,10,10q�6�   $
 Wrap=�6  $	��Top=�6  $	��128��63  $; 5Имя артиста, название трека...��6?  
 �� 	MaxLength$
 30��6~  $ 1��6�  ��6   �� *DurationFieldValue+$ PropertyChanged=� �� 	Converter# [  6�  �� 5   
   $
��Left=�6   $��	10,53,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   �� 6o    � Language$ ru-ru�6s   $!�Выбор артистов��6�   6�   �� 5   
   $
	 Name��63   $
��Left=�6~   $��	10,69,0,0q�6�   $	��Top=�6�   $	��128��6�    �� 
IsEditable$
 True��6�    �� StaysOpenOnEdit$
 True��6�   ��6   �� *	Artists+ �� SelectedItem 6L   �� *SelectedArtistFieldValue+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ DropDownOpened��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *UpdateArtistsListCommand+5      5      �� 5   
   $+��%Добавить выбранного��6h   $
��Left=�6�   $��	10,96,0,0q�6�   $	��Top=�6�   $	��128��6�   ��6   �� *AddAuthorCommand+{�66   �� *AddAuthorCommand.CanExecute+6�   5      5      