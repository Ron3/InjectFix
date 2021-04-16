/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Ldelem_R8,
        Stobj,
        Conv_I8,
        Ldind_I,

        //Pseudo instruction
        StackSpace,
        Not,
        Conv_Ovf_I8_Un,
        Ldelem_Ref,
        Ldelem_U1,
        Beq,
        Bgt_Un,
        Stind_I2,
        Conv_Ovf_I,
        Ldind_I4,
        Conv_Ovf_I_Un,
        Conv_Ovf_U1,
        Ldtoken,
        Bne_Un,
        Brfalse,
        Leave,
        Blt,
        Conv_I2,
        Ldobj,
        Stelem_Ref,
        Conv_Ovf_U8,
        Conv_U,
        Stind_I1,
        Conv_U2,
        Stind_I8,
        Volatile,
        Conv_Ovf_U2_Un,
        Add_Ovf_Un,
        //Calli,
        Conv_Ovf_I4_Un,
        Constrained,
        Ldc_I8,
        Callvirtvirt,
        Ble,
        Ldind_R4,
        Rem,
        Mul_Ovf,
        Ldvirtftn,
        CallExtern,
        Ldftn,
        Ret,
        Blt_Un,
        Neg,
        Ldind_Ref,
        Newanon,
        Conv_Ovf_I1_Un,
        Conv_Ovf_U1_Un,
        Newarr,
        Unbox,
        Rethrow,
        Add,
        Localloc,
        Conv_R8,
        Ldc_I4,
        Ldloca,
        Conv_U4,
        Sub_Ovf_Un,
        Arglist,
        Mul_Ovf_Un,
        Conv_Ovf_I1,
        Ldlen,
        Starg,
        Ldstr,
        Conv_Ovf_U4_Un,
        Dup,
        Stfld,
        Conv_I,
        Stind_I,
        Ldind_U2,
        Ceq,
        Ldelem_Any,
        Refanytype,
        Shr_Un,
        Ldind_U4,
        Isinst,
        Initobj,
        Stind_R4,
        Stind_I4,
        Unbox_Any,
        Mul,
        Ldfld,
        Stelem_Any,
        Ldc_R4,
        Unaligned,
        Br,
        Ldtype, // custom
        Box,
        Stloc,
        Stelem_I,
        Ldsflda,
        Ldloc,
        Conv_Ovf_U4,
        Stind_Ref,
        Ldelem_I4,
        Tail,
        Ldelem_R4,
        Jmp,
        Ldelem_I1,
        Ldelem_I8,
        Sub_Ovf,
        Callvirt,
        Xor,
        Ldind_I1,
        Call,
        Cpobj,
        Brtrue,
        Conv_I4,
        Div_Un,
        Conv_U1,
        Ldvirtftn2,
        Stelem_I2,
        Ldind_R8,
        Conv_Ovf_I4,
        Endfilter,
        Endfinally,
        Sizeof,
        Bge_Un,
        Ldelem_U2,
        Clt_Un,
        Stsfld,
        Bgt,
        Conv_Ovf_U8_Un,
        Div,
        Ldelema,
        Add_Ovf,
        Stelem_I8,
        Conv_Ovf_I2_Un,
        Mkrefany,
        Ldarg,
        Stelem_I1,
        Pop,
        Castclass,
        Conv_Ovf_U2,
        Conv_Ovf_U_Un,
        Ldflda,
        And,
        Shl,
        Initblk,
        Ldind_I2,
        Ldind_U1,
        Bge,
        Ldarga,
        Stelem_R8,
        Nop,
        Stelem_I4,
        Conv_Ovf_U,
        Cgt_Un,
        No,
        Ldelem_I2,
        Refanyval,
        Ldnull,
        Ldind_I8,
        Or,
        Conv_R_Un,
        Conv_I1,
        Cpblk,
        Break,
        Stelem_R4,
        Throw,
        Cgt,
        Conv_U8,
        Conv_Ovf_I2,
        Ldsfld,
        Ldc_R8,
        Ldelem_I,
        Conv_Ovf_I8,
        Shr,
        Clt,
        Readonly,
        Ckfinite,
        Rem_Un,
        Sub,
        Ble_Un,
        Conv_R4,
        Stind_R8,
        Ldelem_U4,
        Switch,
        Newobj,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 6376825851328023288;

        /// <summary>
        /// 当前指令
        /// </summary>
        public Code Code;

        /// <summary>
        /// 操作数
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}