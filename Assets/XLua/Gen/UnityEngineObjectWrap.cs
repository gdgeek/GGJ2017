﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace CSObjectWrap
{
    public class UnityEngineObjectWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Object), L, translator, 1, 4, 2, 2);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInstanceID", GetInstanceID);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", Equals);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideFlags", get_hideFlags);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", set_name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hideFlags", set_hideFlags);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Object), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Object), L, __CreateInstance, 8, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Destroy", Destroy_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DestroyImmediate", DestroyImmediate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindObjectsOfType", FindObjectsOfType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DontDestroyOnLoad", DontDestroyOnLoad_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DestroyObject", DestroyObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Instantiate", Instantiate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindObjectOfType", FindObjectOfType_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Object));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Object), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Object __cl_gen_ret = new UnityEngine.Object();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Object constructor!");
            
        }
        
		
        
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2))
				{
					UnityEngine.Object leftside = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					UnityEngine.Object rightside = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Object!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Destroy_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    UnityEngine.Object.Destroy( obj );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    float t = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Object.Destroy( obj, t );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Object.Destroy!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int DestroyImmediate_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    UnityEngine.Object.DestroyImmediate( obj );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    bool allowDestroyingAssets = LuaAPI.lua_toboolean(L, 2);
                    
                    UnityEngine.Object.DestroyImmediate( obj, allowDestroyingAssets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Object.DestroyImmediate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindObjectsOfType_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        UnityEngine.Object[] __cl_gen_ret = UnityEngine.Object.FindObjectsOfType( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int DontDestroyOnLoad_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object target = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    UnityEngine.Object.DontDestroyOnLoad( target );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int DestroyObject_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    UnityEngine.Object.DestroyObject( obj );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    float t = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Object.DestroyObject( obj, t );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Object.DestroyObject!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int ToString(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Object __cl_gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetInstanceID(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Object __cl_gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetInstanceID(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetHashCode(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Object __cl_gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Equals(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Object __cl_gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    object o = translator.GetObject(L, 2, typeof(object));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Equals( o );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Instantiate_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        UnityEngine.Object __cl_gen_ret = UnityEngine.Object.Instantiate( original );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    UnityEngine.Object original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Object __cl_gen_ret = UnityEngine.Object.Instantiate( original, parent );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Object original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    bool worldPositionStays = LuaAPI.lua_toboolean(L, 3);
                    
                        UnityEngine.Object __cl_gen_ret = UnityEngine.Object.Instantiate( original, parent, worldPositionStays );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    UnityEngine.Object original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    
                        UnityEngine.Object __cl_gen_ret = UnityEngine.Object.Instantiate( original, position, rotation );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
                {
                    UnityEngine.Object original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Object __cl_gen_ret = UnityEngine.Object.Instantiate( original, position, rotation, parent );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Object.Instantiate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindObjectOfType_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        UnityEngine.Object __cl_gen_ret = UnityEngine.Object.FindObjectOfType( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_name(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Object __cl_gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.name);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_hideFlags(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Object __cl_gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.hideFlags);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_name(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Object __cl_gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_hideFlags(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Object __cl_gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
                UnityEngine.HideFlags __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.hideFlags = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
