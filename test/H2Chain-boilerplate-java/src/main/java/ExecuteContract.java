import contarctImpl.Implement.ContractDemo;

/**
 * @Author zyh
 * @Date 2022/6/24 3:20 下午
 * @Version 1.0
 */
public class ExecuteContract {
    /**
     * 执行合约 arg[0] 函数名 arg[1] 参数名
     * @param args
     */
    public static void main(String[] args) {
        if(args.length < 1){
            System.out.println("no params...");
            System.exit(0);
        }

        String contractFuncName = args[0];
        String params = args[1];
        //System.out.println(params);
        //注意第二个参数为JSON串，在cmd传参时需要用双引号包起来，试做一个整体
        if(contractFuncName.equals("updateState")){
            try {
                Boolean updateState = ContractDemo.updateState(params);
                System.out.println(updateState);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }
}
