﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34011
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Databinding.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property _3_5_Disk_Drive() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("3.5_Disk_Drive", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property delete() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("delete", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Folder_Open() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Folder_Open", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Honiara / Henderson, Solomon Islands
        '''Santa Cruz, Solomon Islands
        '''Munda, Solomon Islands
        '''Nauru Airport, Nauru
        '''Madang, Papua New Guinea
        '''Manus Island/Momote, Papua New Guinea
        '''Moresby, Papua New Guinea
        '''Wewak, Papua New Guinea
        '''Tasiilaq, Greenland
        '''Angisoq, Greenland
        '''Aputiteeq, Greenland
        '''Narsarsuaq, Greenland
        '''Constable Pynt, Greenland
        '''Daneborg, Greenland
        '''Danmarkshavn, Greenland
        '''Egedesminde, Greenland
        '''Frederikshaab, Greenland
        '''Groennedal, Greenland
        '''Godthaab / Nuuk, Greenland
        '''Holsteinsborg, Greenla [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property WeatherStations() As String
            Get
                Return ResourceManager.GetString("WeatherStations", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
