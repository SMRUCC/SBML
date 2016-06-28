﻿#Region "Microsoft.VisualBasic::f136770cc3b19af1f5dab0d107e39f60, ..\SBML\Components\Specie.vb"

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

Imports LANS.SystemsBiology.Assembly.SBML.FLuxBalanceModel
Imports Microsoft.VisualBasic.ComponentModel.Collection.Generic
Imports System.Xml.Serialization
Imports LANS.SystemsBiology.Assembly.SBML.Specifics.MetaCyc

Namespace Components

    Public Class Specie : Inherits IPartsBase
        Implements sIdEnumerable

        <Escaped> <XmlAttribute>
        Public Overrides Property id As String Implements sIdEnumerable.Identifier

        <Escaped>
        <XmlAttribute("compartment")>
        Public Overridable Property CompartmentID As String
        <XmlAttribute()>
        Public Property boundaryCondition As Boolean

        Public Overrides Function ToString() As String
            Return String.Format("[{0}]{1} [{2}]", id, name, CompartmentID)
        End Function
    End Class
End Namespace
