// GENERATED AUTOMATICALLY FROM 'Assets/Utilities/PlayerControls.inputactions'

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
            ""name"": ""TreadmillControls"",
            ""id"": ""1561bca8-412d-496b-92b5-3abc370198db"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e7a5eea3-809c-4123-8b19-9849eb28d68a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""2694b40a-2e8d-46ea-a6c8-25e837754040"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Utilities"",
                    ""type"": ""Button"",
                    ""id"": ""4f28d920-e9c0-4269-9568-5a739e3d6d6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASDKeys"",
                    ""id"": ""2a12f482-6f12-455f-8a71-2d8413ff3453"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""17a11d51-473a-4a64-8214-58dae2502313"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""27ff280a-2765-4f39-a2aa-86a35e3c3367"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""89f0a868-14cf-451f-88d9-02d57d24dc56"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""00a7354a-4362-4a22-8c95-b908a9ffd6a9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""5ef1ee13-ab71-4316-b7bc-095794b4e39a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c6de84f9-aee5-42bb-9d3f-aa2fc356f00b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""278f066b-9cea-4fc3-accc-7b86f0eb3b04"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7b85053a-6258-4653-8d8e-47bd7e76da73"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8f685be5-fced-43b6-b93c-59f0ff8f33f0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d9f64adf-b3e1-42fa-9e6f-4e663b4d8556"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0064215-8913-4803-99a6-8794fb5749ae"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bd26276-75f5-4895-8a92-a24e38b747ee"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Utilities"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""7c4a8bb7-8214-4f61-aa6e-912a7510811a"",
            ""actions"": [
                {
                    ""name"": ""MenuInteractions1"",
                    ""type"": ""Button"",
                    ""id"": ""9f40d608-8711-4f79-afaf-09a3cc179db2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a58ff18b-af08-45a1-b243-95904a3c1d04"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuInteractions1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TreadmillControls
        m_TreadmillControls = asset.FindActionMap("TreadmillControls", throwIfNotFound: true);
        m_TreadmillControls_Movement = m_TreadmillControls.FindAction("Movement", throwIfNotFound: true);
        m_TreadmillControls_Dash = m_TreadmillControls.FindAction("Dash", throwIfNotFound: true);
        m_TreadmillControls_Utilities = m_TreadmillControls.FindAction("Utilities", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_MenuInteractions1 = m_Menu.FindAction("MenuInteractions1", throwIfNotFound: true);
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

    // TreadmillControls
    private readonly InputActionMap m_TreadmillControls;
    private ITreadmillControlsActions m_TreadmillControlsActionsCallbackInterface;
    private readonly InputAction m_TreadmillControls_Movement;
    private readonly InputAction m_TreadmillControls_Dash;
    private readonly InputAction m_TreadmillControls_Utilities;
    public struct TreadmillControlsActions
    {
        private @PlayerControls m_Wrapper;
        public TreadmillControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_TreadmillControls_Movement;
        public InputAction @Dash => m_Wrapper.m_TreadmillControls_Dash;
        public InputAction @Utilities => m_Wrapper.m_TreadmillControls_Utilities;
        public InputActionMap Get() { return m_Wrapper.m_TreadmillControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TreadmillControlsActions set) { return set.Get(); }
        public void SetCallbacks(ITreadmillControlsActions instance)
        {
            if (m_Wrapper.m_TreadmillControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnMovement;
                @Dash.started -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnDash;
                @Utilities.started -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnUtilities;
                @Utilities.performed -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnUtilities;
                @Utilities.canceled -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnUtilities;
            }
            m_Wrapper.m_TreadmillControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Utilities.started += instance.OnUtilities;
                @Utilities.performed += instance.OnUtilities;
                @Utilities.canceled += instance.OnUtilities;
            }
        }
    }
    public TreadmillControlsActions @TreadmillControls => new TreadmillControlsActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_MenuInteractions1;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuInteractions1 => m_Wrapper.m_Menu_MenuInteractions1;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @MenuInteractions1.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenuInteractions1;
                @MenuInteractions1.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenuInteractions1;
                @MenuInteractions1.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenuInteractions1;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MenuInteractions1.started += instance.OnMenuInteractions1;
                @MenuInteractions1.performed += instance.OnMenuInteractions1;
                @MenuInteractions1.canceled += instance.OnMenuInteractions1;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface ITreadmillControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnUtilities(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnMenuInteractions1(InputAction.CallbackContext context);
    }
}
