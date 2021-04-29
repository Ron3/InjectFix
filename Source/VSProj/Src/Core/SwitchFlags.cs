/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace IFix
{
    //切换到解析执行
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field)]
    public class InterpretAttribute : Attribute
    {
        // public int ver = 0;
        public int[] verArray;
        public InterpretAttribute()
        {
            this.verArray = new int[1];
            this.verArray[0] = 0;
        }

        public InterpretAttribute(params int[] v)
        {
            this.verArray = v;
        }
        
        public int maxVer
        {
            get{
                return this.verArray.Max();
            }
        }
    }


    //直接在要做成补丁的方法上打标签
    [AttributeUsage(AttributeTargets.Method)]
    public class PatchAttribute : Attribute
    {
        // public int ver = 0;
        // public List<int> verList;
        public int[] verArray;
        public PatchAttribute()
        {
            this.verArray = new int[1];
            this.verArray[0] = 0;
        }

        // public PatchAttribute(int v)
        // {
            
        // }

        public PatchAttribute(params int[] v)
        {
            this.verArray = v;
        }

        public int maxVer
        {
            get{
                return this.verArray.Max();
            }
        }
    }

    //可以手动指定要生成delegate（主要用于闭包）、interface（比如迭代器语法糖）的桥接
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomBridgeAttribute : Attribute
    {

    }
}