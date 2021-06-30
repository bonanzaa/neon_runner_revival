// GENERATED AUTOMATICALLY FROM 'Assets/3rdParty/Utilities/PlayerControls.inputactions'

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
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""569c57ea-28c9-4724-b739-c7b9c21ba8e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""470be35a-8d28-4335-a2bb-3778f8a05b05"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DEBUG_RESET"",
                    ""type"": ""Button"",
                    ""id"": ""54187823-7179-44e1-bc35-3da3bc01fa9b"",
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
                    ""id"": ""13fae4fd-9835-49fb-9f30-c1638a035a6b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a51186e-163c-445f-bc3a-aa678ad851de"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95fdcde0-8cd3-48f7-9d70-cbbe4d3ee462"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DEBUG_RESET"",
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
                },
                {
                    ""name"": ""Navigation"",
                    ""type"": ""Value"",
                    ""id"": ""a2deec31-920b-48ca-8484-b713d8c1e046"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""064caa80-93c1-42cd-9edf-4880c8ed480b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pointer"",
                    ""type"": ""Button"",
                    ""id"": ""7a49da74-a1a3-4669-a110-cd666dbcc4f6"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""7a4f8e90-6fae-4f3c-9dcf-37c4b4160779"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuInteractions1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ab9f864c-bf8f-427b-bd8e-bc81bd2d7bbf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""30668918-40d3-4fea-8c4a-3fdf1c1e9b53"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""05828f87-e6b5-4105-a1cf-30775ad58807"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4e6e5a71-1f1b-4dd3-9a95-5d8d74307415"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a5e47313-477c-49f7-a2ec-3ad9ec859b3b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""74c1d80e-fcfd-44fc-b4aa-c2a425c6f970"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""77b02483-fcef-4f6a-b9eb-91666584a294"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d9d2465c-9af4-444e-b3cd-253c7fbcb7bd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c7ef371b-30cf-492c-8926-5c84a4b0fcac"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d78a6220-f987-4fad-8fe3-c41b337eeb84"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4500f900-8868-4cc9-a54d-fd16edafe110"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb1fdabf-808a-405d-b1ff-ee4455f1162b"",
                    ""path"": ""<AndroidJoystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5429cba-99c9-4774-9fb7-b556337f7a66"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8f3fd4f-4787-408e-ac53-818161fd83f1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0bd2fc6-981a-424b-9d12-ad8d6a4e41e4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7cbf148-2776-43eb-b0b9-8f0d88a649af"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f29568c2-0e46-43ce-a968-2d050962bd71"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pointer"",
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
        m_TreadmillControls_Shoot = m_TreadmillControls.FindAction("Shoot", throwIfNotFound: true);
        m_TreadmillControls_MousePosition = m_TreadmillControls.FindAction("MousePosition", throwIfNotFound: true);
        m_TreadmillControls_DEBUG_RESET = m_TreadmillControls.FindAction("DEBUG_RESET", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_MenuInteractions1 = m_Menu.FindAction("MenuInteractions1", throwIfNotFound: true);
        m_Menu_Navigation = m_Menu.FindAction("Navigation", throwIfNotFound: true);
        m_Menu_Click = m_Menu.FindAction("Click", throwIfNotFound: true);
        m_Menu_Pointer = m_Menu.FindAction("Pointer", throwIfNotFound: true);
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
    private readonly InputAction m_TreadmillControls_Shoot;
    private readonly InputAction m_TreadmillControls_MousePosition;
    private readonly InputAction m_TreadmillControls_DEBUG_RESET;
    public struct TreadmillControlsActions
    {
        private @PlayerControls m_Wrapper;
        public TreadmillControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_TreadmillControls_Movement;
        public InputAction @Dash => m_Wrapper.m_TreadmillControls_Dash;
        public InputAction @Shoot => m_Wrapper.m_TreadmillControls_Shoot;
        public InputAction @MousePosition => m_Wrapper.m_TreadmillControls_MousePosition;
        public InputAction @DEBUG_RESET => m_Wrapper.m_TreadmillControls_DEBUG_RESET;
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
                @Shoot.started -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnShoot;
                @MousePosition.started -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnMousePosition;
                @DEBUG_RESET.started -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnDEBUG_RESET;
                @DEBUG_RESET.performed -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnDEBUG_RESET;
                @DEBUG_RESET.canceled -= m_Wrapper.m_TreadmillControlsActionsCallbackInterface.OnDEBUG_RESET;
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
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @DEBUG_RESET.started += instance.OnDEBUG_RESET;
                @DEBUG_RESET.performed += instance.OnDEBUG_RESET;
                @DEBUG_RESET.canceled += instance.OnDEBUG_RESET;
            }
        }
    }
    public TreadmillControlsActions @TreadmillControls => new TreadmillControlsActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_MenuInteractions1;
    private readonly InputAction m_Menu_Navigation;
    private readonly InputAction m_Menu_Click;
    private readonly InputAction m_Menu_Pointer;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuInteractions1 => m_Wrapper.m_Menu_MenuInteractions1;
        public InputAction @Navigation => m_Wrapper.m_Menu_Navigation;
        public InputAction @Click => m_Wrapper.m_Menu_Click;
        public InputAction @Pointer => m_Wrapper.m_Menu_Pointer;
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
                @Navigation.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNavigation;
                @Navigation.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNavigation;
                @Navigation.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNavigation;
                @Click.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                @Pointer.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPointer;
                @Pointer.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPointer;
                @Pointer.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPointer;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MenuInteractions1.started += instance.OnMenuInteractions1;
                @MenuInteractions1.performed += instance.OnMenuInteractions1;
                @MenuInteractions1.canceled += instance.OnMenuInteractions1;
                @Navigation.started += instance.OnNavigation;
                @Navigation.performed += instance.OnNavigation;
                @Navigation.canceled += instance.OnNavigation;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Pointer.started += instance.OnPointer;
                @Pointer.performed += instance.OnPointer;
                @Pointer.canceled += instance.OnPointer;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface ITreadmillControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnDEBUG_RESET(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnMenuInteractions1(InputAction.CallbackContext context);
        void OnNavigation(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnPointer(InputAction.CallbackContext context);
    }
}
