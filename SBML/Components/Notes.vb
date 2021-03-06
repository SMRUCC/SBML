﻿#Region "Microsoft.VisualBasic::a06d178ece4739dc15924f232496b5a6, ..\GCModeller\models\SBML\SBML\Components\Notes.vb"

    ' Author:
    ' 
    '       asuka (amethyst.asuka@gcmodeller.org)
    '       xieguigang (xie.guigang@live.com)
    ' 
    ' Copyright (c) 2016 GPL3 Licensed
    ' 
    ' 
    ' GNU GENERAL PUBLIC LICENSE (GPL3)
    ' 
    ' This program is free software: you can redistribute it and/or modify
    ' it under the terms of the GNU General Public License as published by
    ' the Free Software Foundation, either version 3 of the License, or
    ' (at your option) any later version.
    ' 
    ' This program is distributed in the hope that it will be useful,
    ' but WITHOUT ANY WARRANTY; without even the implied warranty of
    ' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    ' GNU General Public License for more details.
    ' 
    ' You should have received a copy of the GNU General Public License
    ' along with this program. If not, see <http://www.gnu.org/licenses/>.

#End Region

Imports System.Text.RegularExpressions
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.ComponentModel.Collection.Generic
Imports Microsoft.VisualBasic.Linq.Extensions

Namespace Components

    <XmlType("notes")> Public Class Notes
        Public Property body As Body

        Public ReadOnly Property Text As String
            Get
                If body Is Nothing Then
                    Return ""
                Else
                    Return body.Text
                End If
            End Get
        End Property

        Public ReadOnly Property Properties As [Property]()
            Get
                If body Is Nothing Then
                    Return New [Property]() {}
                Else
                    Return body.GetProperties
                End If
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    <XmlType("body")> Public Class Body
        <XmlElement("p")> Public Property Passage As String()
        <XmlText> Public Property Text As String

        Public Function GetProperties() As [Property]()
            Return Passage.ToArray(Function(s) [Property].Parser(s))
        End Function

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Public Class [Property] : Implements IReadOnlyId, sIdEnumerable
        Implements IKeyValuePairObject(Of String, String)

        Public Property Name As String Implements IKeyValuePairObject(Of String, String).Identifier, IReadOnlyId.Identity, sIdEnumerable.Identifier
        Public Property value As String Implements IKeyValuePairObject(Of String, String).Value

        Public Overrides Function ToString() As String
            Return $"[{Name}]  {value}"
        End Function

        Public Shared Function Parser(s As String) As [Property]
            Dim i As Integer = InStr(s, ":")
            Dim name As String = Mid(s, 1, i - 1)
            Dim value As String = Mid(s, i + 1).Trim

            Return New [Property] With {
                .Name = name,
                .value = value
            }
        End Function
    End Class
End Namespace
