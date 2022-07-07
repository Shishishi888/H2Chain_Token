package contarctImpl.Implement;

import H2ChainUtil.HexUtil.HexUtil;
import com.alibaba.fastjson.JSONObject;
import contarctImpl.State.StateDemo;
import contractAPI.H2ChainAPI;

/**
 * @Author zyh
 * @Date 2022/6/19 7:11 下午
 * @Version 1.0
 */
public class ContractDemo {

    public static Boolean updateState(String info) throws Exception {

        //向链上发起请求，获取链上当前状态
        String curState = H2ChainAPI.getInfo(StateDemo.class.getName());

        //编写逻辑
        StateDemo stateDemo = JSONObject.parseObject(HexUtil.HexStringToString(curState),StateDemo.class);
        //StateDemo updateDemo = JSONObject.parseObject("{\"hash\":\"j28hd3eud2hd878cdh\",\"id\":\"1\"}", StateDemo.class);
        StateDemo updateDemo = JSONObject.parseObject(info, StateDemo.class);
        //System.out.println(info);
        //System.out.println(updateDemo);
        if(stateDemo == null){
            stateDemo = new StateDemo();
        }
        stateDemo.setId(updateDemo.getId());
        stateDemo.setHash(updateDemo.getHash());

        //向链上发起请求，变更链上状态
        H2ChainAPI.setInfo(StateDemo.class.getName() , JSONObject.toJSONString(stateDemo));
        return true;
    }
}
