﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Volumes/nFo/data/etml/codespace/csharp/cosmos/src/interpreter/Cosmos.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace interpreter.antlr {
#pragma warning disable 3021
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CosmosParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ICosmosListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.programme"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgramme([NotNull] CosmosParser.ProgrammeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.programme"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgramme([NotNull] CosmosParser.ProgrammeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.entete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntete([NotNull] CosmosParser.EnteteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.entete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntete([NotNull] CosmosParser.EnteteContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.auteur"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAuteur([NotNull] CosmosParser.AuteurContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.auteur"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAuteur([NotNull] CosmosParser.AuteurContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.date"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDate([NotNull] CosmosParser.DateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.date"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDate([NotNull] CosmosParser.DateContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.entreprise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntreprise([NotNull] CosmosParser.EntrepriseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.entreprise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntreprise([NotNull] CosmosParser.EntrepriseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDescription([NotNull] CosmosParser.DescriptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDescription([NotNull] CosmosParser.DescriptionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.mainStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMainStart([NotNull] CosmosParser.MainStartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.mainStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMainStart([NotNull] CosmosParser.MainStartContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.mainEnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMainEnd([NotNull] CosmosParser.MainEndContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.mainEnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMainEnd([NotNull] CosmosParser.MainEndContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruction([NotNull] CosmosParser.InstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruction([NotNull] CosmosParser.InstructionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.instruction_simple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruction_simple([NotNull] CosmosParser.Instruction_simpleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.instruction_simple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruction_simple([NotNull] CosmosParser.Instruction_simpleContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.instruction_complexe"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruction_complexe([NotNull] CosmosParser.Instruction_complexeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.instruction_complexe"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruction_complexe([NotNull] CosmosParser.Instruction_complexeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.afficher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAfficher([NotNull] CosmosParser.AfficherContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.afficher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAfficher([NotNull] CosmosParser.AfficherContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.selection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelection([NotNull] CosmosParser.SelectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.selection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelection([NotNull] CosmosParser.SelectionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.sinon_si"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSinon_si([NotNull] CosmosParser.Sinon_siContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.sinon_si"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSinon_si([NotNull] CosmosParser.Sinon_siContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.sinon"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSinon([NotNull] CosmosParser.SinonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.sinon"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSinon([NotNull] CosmosParser.SinonContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] CosmosParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] CosmosParser.ConditionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.operateur_comparaison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperateur_comparaison([NotNull] CosmosParser.Operateur_comparaisonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.operateur_comparaison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperateur_comparaison([NotNull] CosmosParser.Operateur_comparaisonContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.expression_valeur"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression_valeur([NotNull] CosmosParser.Expression_valeurContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.expression_valeur"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression_valeur([NotNull] CosmosParser.Expression_valeurContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.expression_textuelle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression_textuelle([NotNull] CosmosParser.Expression_textuelleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.expression_textuelle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression_textuelle([NotNull] CosmosParser.Expression_textuelleContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CosmosParser.expression_numeraire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression_numeraire([NotNull] CosmosParser.Expression_numeraireContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CosmosParser.expression_numeraire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression_numeraire([NotNull] CosmosParser.Expression_numeraireContext context);
}
} // namespace interpreter.antlr
