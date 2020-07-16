﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITPM_Code_Complexity_Tool.Models
{
    public class CdueToSize
    {
        public int lineNo;
        public String CODELINE;
        public int keywordCount;
        public int operatorCount;
        public int variableCount;
        public int numricalCount;
        public int identifires;
        public int stringLiteral;
        public int CI;
        public  int totalCSCal;

        public static int Wkw = 1;
        public static int Wid = 1;
        public static int Wop = 1;
        public static int Wnv = 1;
        public static int Wsl = 1;


        public CdueToSize(int lineNo, String codeline, int keywordCount, int operatorCount, int numricalCount, int identifires, int stringLiteral, int cs)
        {
            this.lineNo = lineNo;
            this.CODELINE = codeline;
            this.keywordCount = keywordCount;
            this.operatorCount = operatorCount;
            this.stringLiteral = stringLiteral;
            this.numricalCount = numricalCount;
            this.identifires = identifires;
            this.CI = cs;
        }
        public CdueToSize(int totalCS)
        {
            
            this.totalCSCal = totalCS;
        }

    }

    public class CdueToVariables
    {
        public int lineNo;
        public String CODELINE;
        public int WeightDueToVScope;
        public int NoPrimitiveDataTypeVariables;
        public int NoCompositeDataTypeVariables;
        public int Cv;
        public int totalVCCal;


        public CdueToVariables(int lineNo, String codeline, int WeightDueToVScope, int NoPrimitiveDataTypeVariables, int NoCompositeDataTypeVariables, int cv)
        {
            this.lineNo = lineNo;
            this.CODELINE = codeline;
            this.WeightDueToVScope = WeightDueToVScope;
            this.NoPrimitiveDataTypeVariables = NoPrimitiveDataTypeVariables;
            this.NoCompositeDataTypeVariables = NoCompositeDataTypeVariables;
            this.Cv = cv;
        }
        public CdueToVariables(int totalVCCal)
        {

            this.totalVCCal = totalVCCal;
        }

    }

    public class CdueToMethod
    {
        public int lineNo;
        public String CODELINE;
        public int NumberOfCompositeDataTypeParameters;
        public int NumberOfPrimitiveDataTypeParameters;
        public int methodReturnType;
        public int Cm;
        public int totalCMCal;


        public CdueToMethod(int lineNo, String codeline, int NumberOfCompositeDataTypeParameters, int NoPrimitiveDataTypeVariables, int methodReturnType, int Cm)
        {
            this.lineNo = lineNo;
            this.CODELINE = codeline;
            this.NumberOfCompositeDataTypeParameters = NumberOfCompositeDataTypeParameters;
            this.NumberOfPrimitiveDataTypeParameters = NoPrimitiveDataTypeVariables;
            this.methodReturnType = methodReturnType;
            this.Cm = Cm;
        }
        public CdueToMethod(int totalCMCal)
        {

            this.totalCMCal = totalCMCal;
        }

    }
}