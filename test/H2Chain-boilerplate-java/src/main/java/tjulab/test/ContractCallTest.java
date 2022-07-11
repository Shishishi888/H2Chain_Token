package tjulab.test;

import H2ChainUtil.HexUtil.HexUtil;
import com.google.protobuf.ByteString;
import com.google.protobuf.Empty;
import io.aelf.protobuf.generated.Core;
import io.aelf.schemas.SendTransactionInput;
import io.aelf.schemas.SendTransactionOutput;
import io.aelf.schemas.TransactionResultDto;
import io.aelf.sdk.AElfClient;
import io.aelf.utils.ByteArrayHelper;
import io.aelf.utils.Sha256;
import org.bouncycastle.util.encoders.Hex;

/**
 * Author: ShiYang
 * Date: 2022.07.01
 */
public class ContractCallTest {
    public static void main(String[] args) throws Exception {
        // create a new instance of AElf, change the URL if needed
        AElfClient client = new AElfClient("http://localhost:8000");  // aelf链运行的服务器
        boolean isConnected = client.isConnected();
        System.out.println(isConnected);

        String privateKey = "b3f6d5ec63f222ccb90c23eac1f1afe490c910e35e0cb947ea968a6181d96828";  // 写上自己的私钥

        String managerListContractAddress = client.getContractAddressByName(privateKey, Sha256.getBytesSha256("AElf.ContractNames.ManagerList"));  // 被调用合约的合约地址；系统合约可以直接通过合约名字获得


        String ownerAddress = client.getAddressFromPrivateKey(privateKey);


        Empty input = Empty.newBuilder().build();

        Core.Transaction.Builder transactionTransfer = null;
        try {
            transactionTransfer = client.generateTransaction(ownerAddress, managerListContractAddress, "TestMySystemContract", input.toByteArray());  // 初始化交易
        } catch (Exception e) {
            e.printStackTrace();
        }
        Core.Transaction transactionTransferObj = transactionTransfer.build();
        try {
            transactionTransfer.setSignature(ByteString.copyFrom(ByteArrayHelper.hexToByteArray(client.signTransaction(privateKey, transactionTransferObj))));
        } catch (Exception e) {
            e.printStackTrace();
        }
        transactionTransferObj = transactionTransfer.build();

        // Send the transfer transaction to AElf chain node.
        SendTransactionInput sendTransactionInputObj = new SendTransactionInput();
        sendTransactionInputObj.setRawTransaction(Hex.toHexString(transactionTransferObj.toByteArray()));
        SendTransactionOutput sendResult = null;
        try {
            sendResult = client.sendTransaction(sendTransactionInputObj);  // 发送交易，返回交易结果
        } catch (Exception e) {
            e.printStackTrace();
        }

        try {
            Thread.sleep(4000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        // After the transaction is mined, query the execution results.
        TransactionResultDto transactionResult = null;
        try {
            transactionResult = client.getTransactionResult(sendResult.getTransactionId());  // 获取交易结果
            System.out.println(transactionResult.getTransactionId());
            System.out.println(transactionResult.getReturnValue());
            System.out.println(HexUtil.HexStringToString(transactionResult.getReturnValue()));
        } catch (Exception e) {
            e.printStackTrace();
        }
        System.out.println(transactionResult.getStatus());
    }
}
