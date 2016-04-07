//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Tom\documents\visual studio 2013\Projects\AclGrammar\AclGrammar\AclScript.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AclGrammar {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="AclScriptParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IAclScriptVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>stringFunction</c>
	/// labeled alternative in <see cref="AclScriptParser.stringExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringFunction([NotNull] AclScriptParser.StringFunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="AclScriptParser.stringExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] AclScriptParser.StringContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>stringAclObjectName</c>
	/// labeled alternative in <see cref="AclScriptParser.stringExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringAclObjectName([NotNull] AclScriptParser.StringAclObjectNameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>stringParenthesis</c>
	/// labeled alternative in <see cref="AclScriptParser.stringExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringParenthesis([NotNull] AclScriptParser.StringParenthesisContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>concatenate</c>
	/// labeled alternative in <see cref="AclScriptParser.stringExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConcatenate([NotNull] AclScriptParser.ConcatenateContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>numberPlusDate</c>
	/// labeled alternative in <see cref="AclScriptParser.datetimeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberPlusDate([NotNull] AclScriptParser.NumberPlusDateContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>time</c>
	/// labeled alternative in <see cref="AclScriptParser.datetimeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime([NotNull] AclScriptParser.TimeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>datePlusNumber</c>
	/// labeled alternative in <see cref="AclScriptParser.datetimeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatePlusNumber([NotNull] AclScriptParser.DatePlusNumberContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>dateFunction</c>
	/// labeled alternative in <see cref="AclScriptParser.datetimeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateFunction([NotNull] AclScriptParser.DateFunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>dateParenthesis</c>
	/// labeled alternative in <see cref="AclScriptParser.datetimeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateParenthesis([NotNull] AclScriptParser.DateParenthesisContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>date</c>
	/// labeled alternative in <see cref="AclScriptParser.datetimeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDate([NotNull] AclScriptParser.DateContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>datetime</c>
	/// labeled alternative in <see cref="AclScriptParser.datetimeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatetime([NotNull] AclScriptParser.DatetimeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>dateAclObjectName</c>
	/// labeled alternative in <see cref="AclScriptParser.datetimeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateAclObjectName([NotNull] AclScriptParser.DateAclObjectNameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>subtract</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubtract([NotNull] AclScriptParser.SubtractContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>numAclObjectName</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumAclObjectName([NotNull] AclScriptParser.NumAclObjectNameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>integer</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInteger([NotNull] AclScriptParser.IntegerContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>exponent</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExponent([NotNull] AclScriptParser.ExponentContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>number</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] AclScriptParser.NumberContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>multiply</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiply([NotNull] AclScriptParser.MultiplyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>divide</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDivide([NotNull] AclScriptParser.DivideContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>numFunction</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumFunction([NotNull] AclScriptParser.NumFunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>negative</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegative([NotNull] AclScriptParser.NegativeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesisSubtractDatetimes</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesisSubtractDatetimes([NotNull] AclScriptParser.ParenthesisSubtractDatetimesContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>add</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdd([NotNull] AclScriptParser.AddContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>subtractDatetimes</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubtractDatetimes([NotNull] AclScriptParser.SubtractDatetimesContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>numParenthesis</c>
	/// labeled alternative in <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumParenthesis([NotNull] AclScriptParser.NumParenthesisContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunc([NotNull] AclScriptParser.FuncContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.numFunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumFunc([NotNull] AclScriptParser.NumFuncContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.datetimeFunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatetimeFunc([NotNull] AclScriptParser.DatetimeFuncContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.stringFunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringFunc([NotNull] AclScriptParser.StringFuncContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.boolFunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolFunc([NotNull] AclScriptParser.BoolFuncContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.abs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAbs([NotNull] AclScriptParser.AbsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.age"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAge([NotNull] AclScriptParser.AgeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.alltrim"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlltrim([NotNull] AclScriptParser.AlltrimContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.ascii"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAscii([NotNull] AclScriptParser.AsciiContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.at"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAt([NotNull] AclScriptParser.AtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.between"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBetween([NotNull] AclScriptParser.BetweenContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.bintostr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBintostr([NotNull] AclScriptParser.BintostrContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.bit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBit([NotNull] AclScriptParser.BitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.blanks"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlanks([NotNull] AclScriptParser.BlanksContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitByte([NotNull] AclScriptParser.ByteContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.cdow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCdow([NotNull] AclScriptParser.CdowContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.chr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChr([NotNull] AclScriptParser.ChrContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.clean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClean([NotNull] AclScriptParser.CleanContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.cmoy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmoy([NotNull] AclScriptParser.CmoyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.cos"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCos([NotNull] AclScriptParser.CosContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.ctod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCtod([NotNull] AclScriptParser.CtodContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.ctodt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCtodt([NotNull] AclScriptParser.CtodtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.ctot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCtot([NotNull] AclScriptParser.CtotContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.cumprinc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCumprinc([NotNull] AclScriptParser.CumprincContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.cumipmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCumipmt([NotNull] AclScriptParser.CumipmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.datef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatef([NotNull] AclScriptParser.DatefContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.datetimef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatetimef([NotNull] AclScriptParser.DatetimefContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.day"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDay([NotNull] AclScriptParser.DayContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.dbtye"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDbtye([NotNull] AclScriptParser.DbtyeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.dec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDec([NotNull] AclScriptParser.DecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.dhex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDhex([NotNull] AclScriptParser.DhexContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.dicecoefficient"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDicecoefficient([NotNull] AclScriptParser.DicecoefficientContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDigit([NotNull] AclScriptParser.DigitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.dow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDow([NotNull] AclScriptParser.DowContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.dtou"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDtou([NotNull] AclScriptParser.DtouContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.ebcdic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEbcdic([NotNull] AclScriptParser.EbcdicContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.effective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEffective([NotNull] AclScriptParser.EffectiveContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.eomonth"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEomonth([NotNull] AclScriptParser.EomonthContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.exclude"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExclude([NotNull] AclScriptParser.ExcludeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExp([NotNull] AclScriptParser.ExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.filesize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilesize([NotNull] AclScriptParser.FilesizeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.find"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFind([NotNull] AclScriptParser.FindContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.frequency"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFrequency([NotNull] AclScriptParser.FrequencyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.ftype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFtype([NotNull] AclScriptParser.FtypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.fvannuity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFvannuity([NotNull] AclScriptParser.FvannuityContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.fvlumpsum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFvlumpsum([NotNull] AclScriptParser.FvlumpsumContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.fvschedule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFvschedule([NotNull] AclScriptParser.FvscheduleContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.getoptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGetoptions([NotNull] AclScriptParser.GetoptionsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.gomonth"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGomonth([NotNull] AclScriptParser.GomonthContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.hash"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHash([NotNull] AclScriptParser.HashContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.hex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHex([NotNull] AclScriptParser.HexContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.hour"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHour([NotNull] AclScriptParser.HourContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.htou"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHtou([NotNull] AclScriptParser.HtouContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInclude([NotNull] AclScriptParser.IncludeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.insert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInsert([NotNull] AclScriptParser.InsertContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.intf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntf([NotNull] AclScriptParser.IntfContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.ipmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIpmt([NotNull] AclScriptParser.IpmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.isblank"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsblank([NotNull] AclScriptParser.IsblankContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.isdefined"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsdefined([NotNull] AclScriptParser.IsdefinedContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.isfuzzydup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsfuzzydup([NotNull] AclScriptParser.IsfuzzydupContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.last"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLast([NotNull] AclScriptParser.LastContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] AclScriptParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.numExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumExpr([NotNull] AclScriptParser.NumExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.datetimeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatetimeExpr([NotNull] AclScriptParser.DatetimeExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.stringExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringExpr([NotNull] AclScriptParser.StringExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.boolExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExpr([NotNull] AclScriptParser.BoolExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.sep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSep([NotNull] AclScriptParser.SepContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.fStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFStart([NotNull] AclScriptParser.FStartContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.fEnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFEnd([NotNull] AclScriptParser.FEndContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.testVARFLD"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTestVARFLD([NotNull] AclScriptParser.TestVARFLDContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.testNUM"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTestNUM([NotNull] AclScriptParser.TestNUMContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.testSTRING"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTestSTRING([NotNull] AclScriptParser.TestSTRINGContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.testDATE"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTestDATE([NotNull] AclScriptParser.TestDATEContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.testBOOL"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTestBOOL([NotNull] AclScriptParser.TestBOOLContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.testVARSUB"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTestVARSUB([NotNull] AclScriptParser.TestVARSUBContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.testTIME"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTestTIME([NotNull] AclScriptParser.TestTIMEContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AclScriptParser.testDATETIME"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTestDATETIME([NotNull] AclScriptParser.TestDATETIMEContext context);
}
} // namespace AclGrammar