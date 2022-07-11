using System;
using System.Collections.Generic;
using AElf.Types;
using Google.Protobuf;

namespace AElf.Kernel.ManagerList
{

    public interface IManagerListContractInitializationDataProvider
    {
        ManagerListContractInitializationData GetContractInitializationData();
    }

    public class ManagerListContractInitializationData
    {
        public ByteString NativeTokenInfoData { get; set; }
    }

}