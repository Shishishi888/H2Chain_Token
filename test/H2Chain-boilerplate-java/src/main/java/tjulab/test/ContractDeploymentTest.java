package tjulab.test;

import H2ChainUtil.HexUtil.HexUtil;
import com.google.protobuf.ByteString;
import com.google.protobuf.Empty;
import com.google.protobuf.EmptyOrBuilder;
import io.aelf.protobuf.generated.Core;
import io.aelf.protobuf.generated.Genesis;
import io.aelf.schemas.SendTransactionInput;
import io.aelf.schemas.SendTransactionOutput;
import io.aelf.schemas.TransactionResultDto;
import io.aelf.sdk.AElfClient;
import io.aelf.utils.ByteArrayHelper;
import io.aelf.utils.Sha256;
import org.bouncycastle.util.encoders.Hex;

import java.io.*;
import java.nio.charset.StandardCharsets;

/**
 * Author: ShiYang
 * Date: 2022.07.05
 */
public class ContractDeploymentTest {
    public static void main(String[] args) throws Exception {
        // create a new instance of AElf, change the URL if needed
        AElfClient client = new AElfClient("http://localhost:8000");
        boolean isConnected = client.isConnected();
        System.out.println(isConnected);

        String genesisContractAddress = "pykr77ft9UUKJZLVq15wCH8PinBSjVRQ12sD1Ayq92mKFsJ1i";

        String privateKey = "b3f6d5ec63f222ccb90c23eac1f1afe490c910e35e0cb947ea968a6181d96828";

        String ownerAddress = client.getAddressFromPrivateKey(privateKey);

        File file = new File("/Users/shiyang/Projects/Tianjin_University_Blockchain_Lab/HaiheSmartChain/H2Chain_Token/test/dll/AElf.Contracts.DemoContract.dll.patched");
        FileInputStream fileInputStream = null;
        byte[] fileBytes = null;
        try {
            fileInputStream = new FileInputStream(file);
            fileBytes = new byte[fileInputStream.available()];
            fileInputStream.read(fileBytes);
            fileInputStream.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        Genesis.ContractDeploymentInput.Builder paramContractDeployment = Genesis.ContractDeploymentInput.newBuilder();
        paramContractDeployment.setCategory(0);
        paramContractDeployment.setCode(ByteString.copyFrom(fileBytes));
        Genesis.ContractDeploymentInput paramContractDeploymentObj = paramContractDeployment.build();

        Core.Transaction.Builder transactionTransfer = null;
        try {
            transactionTransfer = client.generateTransaction(ownerAddress, genesisContractAddress, "DeploySmartContract", paramContractDeploymentObj.toByteArray());
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
            sendResult = client.sendTransaction(sendTransactionInputObj);
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
            transactionResult = client.getTransactionResult(sendResult.getTransactionId());
            System.out.println(transactionResult.getTransactionId());
            System.out.println(transactionResult.getReturnValue());
            System.out.println(Hex.toHexString(transactionResult.getReturnValue().getBytes(StandardCharsets.UTF_8)));

        } catch (Exception e) {
            e.printStackTrace();
        }

        System.out.println(transactionResult.getStatus());
    }
}

