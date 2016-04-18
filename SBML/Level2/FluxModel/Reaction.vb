﻿Imports System.Text
Imports LANS.SystemsBiology.ComponentModel.EquaionModel
Imports Microsoft.VisualBasic.ComponentModel.Collection.Generic
Imports System.Xml.Serialization
Imports LANS.SystemsBiology.Assembly.SBML.Components
Imports LANS.SystemsBiology.Assembly.SBML.Specifics.MetaCyc
Imports LANS.SystemsBiology.Assembly.SBML.FLuxBalanceModel.IFBA

Namespace Level2.Elements

    'http://sbml.org/Software/libSBML/docs/java-api/org/sbml/libsbml/Reaction.html

    ''' <summary>
    ''' A reaction represents any transformation, transport or binding process, typically a chemical reaction, 
    ''' that can change the quantity of one or more species. In SBML, a reaction is defined primarily in terms 
    ''' of the participating reactants and products (and their corresponding stoichiometries), along with 
    ''' optional modifier species, an optional rate at which the reaction takes place, and optional parameters.
    ''' </summary>
    ''' <remarks></remarks>
    <XmlType("reaction")> Public Class Reaction : Inherits Equation(Of speciesReference)
        Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference)
        Implements IReadOnlyId

        <XmlIgnore()> Public Handle As Integer
        <Escaped> <XmlAttribute()> Public Property id As String Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference).Identifier, IReadOnlyId.locusId
        ''' <summary>
        ''' Name property is the UniqueId in the MetaCyc database.(reactions.dat)
        ''' </summary>
        ''' <remarks></remarks>
        <XmlAttribute()> Public Property name As String Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference).Name
        <XmlAttribute()> Public Overrides Property reversible As Boolean Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference).Reversible
        <XmlArray("listOfReactants")> Public Overrides Property Reactants As speciesReference() Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference).Reactants
            Get
                Return MyBase.Reactants
            End Get
            Set(value As speciesReference())
                MyBase.Reactants = value
            End Set
        End Property
        <XmlArray("listOfProducts")> Public Overrides Property Products As speciesReference() Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference).Products
            Get
                Return MyBase.Products
            End Get
            Set(value As speciesReference())
                MyBase.Products = value
            End Set
        End Property
        Public Property kineticLaw As kineticLaw
        <XmlElement("notes")> Public Property Notes As Notes

        Public ReadOnly Property LowerBound As Double Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference).LOWER_BOUND
            Get
                Dim param = kineticLaw.GetParameter(LOWER_BOUND)
                If param Is Nothing Then
                    Return 0
                Else
                    Return param.value
                End If
            End Get
        End Property

        Public ReadOnly Property UpperBound As Double Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference).UPPER_BOUND
            Get
                Dim param = kineticLaw.GetParameter(UPPER_BOUND)
                If param Is Nothing Then
                    Return 0
                Else
                    Return param.value
                End If
            End Get
        End Property

        Public Overrides Function GetCoEfficient(ID As String) As Double Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference).GetStoichiometry
            Return MyBase.GetCoEfficient(ID)
        End Function

        Public Overrides Function ToString() As String
            Return String.Format("[{0}]{1}; reversible={2}", id, name, reversible)
        End Function

        Protected Overrides Function __equals(a As speciesReference, b As speciesReference, strict As Boolean) As Object
            Return Equivalence.Equals(a, b, strict)
        End Function

        Public ReadOnly Property ObjectiveCoefficient As Integer Implements FLuxBalanceModel.I_ReactionModel(Of speciesReference).ObjectiveCoefficient
            Get
                Return kineticLaw.ObjectiveCoefficient
            End Get
        End Property
    End Class
End Namespace