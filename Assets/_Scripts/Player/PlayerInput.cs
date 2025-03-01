//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Scripts/Player/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Player
{
    public partial class @PlayerInput: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""a96aa1e0-6cbe-4382-9422-55ddc3d31b61"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a71870aa-f318-4c0d-b2d8-dd55c03d06bf"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Movement Special"",
                    ""type"": ""Button"",
                    ""id"": ""35f143cf-3e9d-4a4b-a0b6-f414c1da7710"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack Primary"",
                    ""type"": ""Button"",
                    ""id"": ""37f887c3-85b7-40b1-9255-9f6279162e9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack Secondary"",
                    ""type"": ""Button"",
                    ""id"": ""ab7c0ff3-431f-4df6-a134-67c191ebe39a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""2673eeeb-55de-4cea-8beb-7fa2f56e065d"",
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
                    ""id"": ""8c4ed36a-c993-4b44-adda-b72d220b2435"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""afaa2573-5a38-4a5e-b2bb-8a5c2ba08480"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c41059e9-10e6-4714-862c-2a393b734e13"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8ce78728-6c52-493f-8751-b007e8140b22"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""0b7ce203-0c4b-429e-93db-a719d4e09db9"",
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
                    ""id"": ""9c09657e-7a50-4e72-8857-d8e39ca2e370"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d2c51f97-dcf9-4b08-b574-3166ab725a07"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1d5b563b-9f0a-463f-a7e4-4f1bb3228845"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cd813e29-0688-4ecf-83be-d56713156292"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e6b3fcef-51c9-44ff-82da-890676a24437"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac4e258d-2c87-4cb0-8c67-fec90667ec8b"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Movement Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""293d6f92-015b-448d-9e62-8412b4676373"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Attack Primary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7552f6ec-bd24-427f-8350-85baef29417a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Attack Secondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KM"",
            ""bindingGroup"": ""KM"",
            ""devices"": []
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": []
        }
    ]
}");
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
            m_Gameplay_MovementSpecial = m_Gameplay.FindAction("Movement Special", throwIfNotFound: true);
            m_Gameplay_AttackPrimary = m_Gameplay.FindAction("Attack Primary", throwIfNotFound: true);
            m_Gameplay_AttackSecondary = m_Gameplay.FindAction("Attack Secondary", throwIfNotFound: true);
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

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Gameplay
        private readonly InputActionMap m_Gameplay;
        private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
        private readonly InputAction m_Gameplay_Movement;
        private readonly InputAction m_Gameplay_MovementSpecial;
        private readonly InputAction m_Gameplay_AttackPrimary;
        private readonly InputAction m_Gameplay_AttackSecondary;
        public struct GameplayActions
        {
            private @PlayerInput m_Wrapper;
            public GameplayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
            public InputAction @MovementSpecial => m_Wrapper.m_Gameplay_MovementSpecial;
            public InputAction @AttackPrimary => m_Wrapper.m_Gameplay_AttackPrimary;
            public InputAction @AttackSecondary => m_Wrapper.m_Gameplay_AttackSecondary;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void AddCallbacks(IGameplayActions instance)
            {
                if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MovementSpecial.started += instance.OnMovementSpecial;
                @MovementSpecial.performed += instance.OnMovementSpecial;
                @MovementSpecial.canceled += instance.OnMovementSpecial;
                @AttackPrimary.started += instance.OnAttackPrimary;
                @AttackPrimary.performed += instance.OnAttackPrimary;
                @AttackPrimary.canceled += instance.OnAttackPrimary;
                @AttackSecondary.started += instance.OnAttackSecondary;
                @AttackSecondary.performed += instance.OnAttackSecondary;
                @AttackSecondary.canceled += instance.OnAttackSecondary;
            }

            private void UnregisterCallbacks(IGameplayActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @MovementSpecial.started -= instance.OnMovementSpecial;
                @MovementSpecial.performed -= instance.OnMovementSpecial;
                @MovementSpecial.canceled -= instance.OnMovementSpecial;
                @AttackPrimary.started -= instance.OnAttackPrimary;
                @AttackPrimary.performed -= instance.OnAttackPrimary;
                @AttackPrimary.canceled -= instance.OnAttackPrimary;
                @AttackSecondary.started -= instance.OnAttackSecondary;
                @AttackSecondary.performed -= instance.OnAttackSecondary;
                @AttackSecondary.canceled -= instance.OnAttackSecondary;
            }

            public void RemoveCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IGameplayActions instance)
            {
                foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);
        private int m_KMSchemeIndex = -1;
        public InputControlScheme KMScheme
        {
            get
            {
                if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.FindControlSchemeIndex("KM");
                return asset.controlSchemes[m_KMSchemeIndex];
            }
        }
        private int m_ControllerSchemeIndex = -1;
        public InputControlScheme ControllerScheme
        {
            get
            {
                if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
                return asset.controlSchemes[m_ControllerSchemeIndex];
            }
        }
        public interface IGameplayActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnMovementSpecial(InputAction.CallbackContext context);
            void OnAttackPrimary(InputAction.CallbackContext context);
            void OnAttackSecondary(InputAction.CallbackContext context);
        }
    }
}
