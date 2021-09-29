// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Tutorial 1.5"",
            ""id"": ""8cdb2a30-f67e-4e33-9faf-d5ce2a6fe091"",
            ""actions"": [
                {
                    ""name"": ""Play1"",
                    ""type"": ""Button"",
                    ""id"": ""187dfc7e-e8ad-4bb2-99e3-2998aa050c43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Play2"",
                    ""type"": ""Button"",
                    ""id"": ""d9df7fad-5d69-4259-8185-040b58078804"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Loop"",
                    ""type"": ""Button"",
                    ""id"": ""4d6b5445-2698-4c17-9a0a-c25a72654b81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Abscond"",
                    ""type"": ""Button"",
                    ""id"": ""962f2e22-5bd2-4cb8-b65f-19357af46e88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""985dc384-4a58-49ce-9145-a32742f24d4a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07df288c-4109-4a4f-b5e3-9d4e33babcc0"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76d4289b-db92-469d-91c6-3eb86207bde9"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63936c18-ae81-4f10-8283-8edfa04f01a2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Abscond"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Tutorial 1.5
        m_Tutorial15 = asset.FindActionMap("Tutorial 1.5", throwIfNotFound: true);
        m_Tutorial15_Play1 = m_Tutorial15.FindAction("Play1", throwIfNotFound: true);
        m_Tutorial15_Play2 = m_Tutorial15.FindAction("Play2", throwIfNotFound: true);
        m_Tutorial15_Loop = m_Tutorial15.FindAction("Loop", throwIfNotFound: true);
        m_Tutorial15_Abscond = m_Tutorial15.FindAction("Abscond", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Tutorial 1.5
    private readonly InputActionMap m_Tutorial15;
    private ITutorial15Actions m_Tutorial15ActionsCallbackInterface;
    private readonly InputAction m_Tutorial15_Play1;
    private readonly InputAction m_Tutorial15_Play2;
    private readonly InputAction m_Tutorial15_Loop;
    private readonly InputAction m_Tutorial15_Abscond;
    public struct Tutorial15Actions
    {
        private @PlayerControls m_Wrapper;
        public Tutorial15Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Play1 => m_Wrapper.m_Tutorial15_Play1;
        public InputAction @Play2 => m_Wrapper.m_Tutorial15_Play2;
        public InputAction @Loop => m_Wrapper.m_Tutorial15_Loop;
        public InputAction @Abscond => m_Wrapper.m_Tutorial15_Abscond;
        public InputActionMap Get() { return m_Wrapper.m_Tutorial15; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Tutorial15Actions set) { return set.Get(); }
        public void SetCallbacks(ITutorial15Actions instance)
        {
            if (m_Wrapper.m_Tutorial15ActionsCallbackInterface != null)
            {
                @Play1.started -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnPlay1;
                @Play1.performed -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnPlay1;
                @Play1.canceled -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnPlay1;
                @Play2.started -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnPlay2;
                @Play2.performed -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnPlay2;
                @Play2.canceled -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnPlay2;
                @Loop.started -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnLoop;
                @Loop.performed -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnLoop;
                @Loop.canceled -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnLoop;
                @Abscond.started -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnAbscond;
                @Abscond.performed -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnAbscond;
                @Abscond.canceled -= m_Wrapper.m_Tutorial15ActionsCallbackInterface.OnAbscond;
            }
            m_Wrapper.m_Tutorial15ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Play1.started += instance.OnPlay1;
                @Play1.performed += instance.OnPlay1;
                @Play1.canceled += instance.OnPlay1;
                @Play2.started += instance.OnPlay2;
                @Play2.performed += instance.OnPlay2;
                @Play2.canceled += instance.OnPlay2;
                @Loop.started += instance.OnLoop;
                @Loop.performed += instance.OnLoop;
                @Loop.canceled += instance.OnLoop;
                @Abscond.started += instance.OnAbscond;
                @Abscond.performed += instance.OnAbscond;
                @Abscond.canceled += instance.OnAbscond;
            }
        }
    }
    public Tutorial15Actions @Tutorial15 => new Tutorial15Actions(this);
    public interface ITutorial15Actions
    {
        void OnPlay1(InputAction.CallbackContext context);
        void OnPlay2(InputAction.CallbackContext context);
        void OnLoop(InputAction.CallbackContext context);
        void OnAbscond(InputAction.CallbackContext context);
    }
}
